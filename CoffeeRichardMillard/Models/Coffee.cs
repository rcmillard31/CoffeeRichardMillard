using CoffeeRichardMillard.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRichardMillard.Models
{
    public enum CoffeeSizes { Small = 0, Medium = 1, Large = 2 };
    //private const string[CoffeeSizes]

    public class Coffee : SaleItem
    {
        public static string[] CoffeeSizeText = new string[(int)CoffeeSizes.Large+1] { "Small Coffee", "Medium Coffee", "Large Coffee" };
        public static readonly int MaxSugars = 3;
        public static readonly int MaxCreams = 3;

        public const decimal PriceForSmall = 1.75m;
        public const decimal PriceForMedium = 2.00m;
        public const decimal PriceForLarge = 2.25m;

        /// <summary>
        /// Coffee defaults to Size=Large
        /// </summary>
        public Coffee(IRepository<Sugar> sugars, IRepository<Cream> creams)
        {
            Size = CoffeeSizes.Large;

            Sugars = sugars;
            Creams = creams;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Price of the coffee based on the size</returns>
        public override decimal Price()
        {
            decimal coffeePrice = 0.0m;

            switch (Size)
            {
                case CoffeeSizes.Small:
                    coffeePrice = PriceForSmall;
                    break;
                case CoffeeSizes.Medium:
                    coffeePrice = PriceForMedium;
                    break;
                case CoffeeSizes.Large:
                    coffeePrice = PriceForLarge;
                    break;
                default:
                    coffeePrice = PriceForLarge;
                    break;
            }

            return coffeePrice;
        }

        /// <summary>
        /// Add a single cream to the coffee (to a maximum of MaxCreams)
        /// </summary>
        /// <returns>The newly created cream</returns>
        public Cream AddCream()
        {
            Cream cream = null;

            if (Creams.Count(this) < MaxCreams)
            {
                cream = new Cream();
                Creams.Add(this, cream);
            }
            return cream;
        }

        /// <summary>
        /// Removes a single cream from a coffee - if one exists
        /// </summary>
        /// <param name="cream">The cream to remove</param>
        public void RemoveCream(Cream cream)
        {
            Contract.Requires(cream != null);

            Creams.Remove(cream);
        }

        /// <summary>
        /// Add a single sugar to a coffee, to a maximum of MaxSugars
        /// </summary>
        /// <returns>The newly created sugar</returns>
        public Sugar AddSugar()
        {
            Sugar sugar = null;

            if (Sugars.Count(this) < MaxSugars)
            {
                sugar = new Sugar();
                Sugars.Add(this, sugar);
            }
            return sugar;
        }

        /// <summary>
        /// Remove a sugar from the coffee
        /// </summary>
        /// <param name="sugar">The Sugar to remove</param>
        public void RemoveSugar(Sugar sugar)
        {
            Contract.Requires(sugar != null);

            Sugars.Remove(sugar);
        }
        public override string Description()
        {
            return "Coffee";
        }

        public CoffeeSizes Size { get; set; }

        /// <summary>
        /// Calculates the total price of all sugars in the coffee
        /// </summary>
        /// <returns>Total price of all sugars</returns>
        private decimal TotalSugarPrice()
        {
            decimal tempTotal = 0.0m;
            foreach (Sugar sugar in Sugars.GetAll(this))
            {
                tempTotal += sugar.Price();
            }
            return tempTotal;
        }
        /// <summary>
        /// Returns the total price of all Creams in the coffee
        /// </summary>
        /// <returns>Total Price of all creams</returns>
        private decimal TotalCreamPrice()
        {
            decimal tempTotal = 0.0m;
            foreach (Cream cream in Creams.GetAll(this))
            {
                tempTotal += cream.Price();
            }
            return tempTotal;
        }
        /// <summary>
        /// Returns the Total price of the coffee (Coffee Size Price + Total Sugar Price + Total Cream Price)
        /// </summary>
        /// <returns></returns>
        public decimal Total()
        {
            return TotalSugarPrice() + TotalCreamPrice() + Price();
        }
        public string OutputDescription
        {
            get { return $"{CoffeeSizeText[(int)Size]} - {Sugars.Count(this)} sugar(s), {Creams.Count(this)} cream(s) : {Total()}"; }
        }
        public override string ToString()
        {
            return OutputDescription;
        }

        public IRepository<Sugar> Sugars;
        public IRepository<Cream> Creams;
    }
}
