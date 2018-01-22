using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeRichardMillard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeRichardMillard.Repositories;

namespace CoffeeRichardMillard.Models.Tests
{
    [TestClass()]
    public class CoffeeTests
    {

        [TestMethod()]
        public void CoffeeTest()
        {
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Coffee coffee = new Coffee(sugars, creams);

            Assert.IsNotNull(coffee);
        }

        [TestMethod()]
        public void PriceTest()
        {
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Coffee coffee = new Coffee(sugars, creams);
            coffee.Size = CoffeeSizes.Small;

            Assert.IsTrue(coffee.Price() == Coffee.PriceForSmall, "Small coffee price incorrect");

            coffee.Size = CoffeeSizes.Medium;
            Assert.IsTrue(coffee.Price() == Coffee.PriceForMedium, "Medium coffee price incorrect");

            coffee.Size = CoffeeSizes.Large;
            Assert.IsTrue(coffee.Price() == Coffee.PriceForLarge, "Large coffee price incorrect");
        }

        [TestMethod()]
        public void AddCreamTest()
        {
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Coffee coffee = new Coffee(sugars, creams);
            Cream cream = coffee.AddCream();

            Assert.IsNotNull(cream);
            Assert.IsTrue(coffee.Creams.Count(coffee) == 1);
        }

        [TestMethod()]
        public void RemoveCreamTest()
        {
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Coffee coffee = new Coffee(sugars, creams);
            Cream cream = coffee.AddCream();
            coffee.RemoveCream(cream);

            Assert.IsTrue(coffee.Creams.Count(coffee) == 0);
        }

        [TestMethod()]
        public void AddSugarTest()
        {
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Coffee coffee = new Coffee(sugars, creams);
            Cream cream = coffee.AddCream();

            Assert.IsNotNull(cream);
            Assert.IsTrue(coffee.Creams.Count(coffee) == 1);
        }

        [TestMethod()]
        public void RemoveSugarTest()
        {
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Coffee coffee = new Coffee(sugars, creams);
            Sugar sugar = coffee.AddSugar();
            coffee.RemoveSugar(sugar);

            Assert.IsTrue(coffee.Sugars.Count(sugars) == 0);
        }

        [TestMethod()]
        public void TotalTest()
        {
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Coffee coffee = new Coffee(sugars, creams);
            coffee.Size = CoffeeSizes.Small;
            coffee.AddCream();
            coffee.AddSugar();

            Assert.IsTrue(coffee.Total() == Coffee.PriceForSmall + Cream.PriceForCream + Sugar.PriceForSugar);
        }
    }
}