using CoffeeRichardMillard.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRichardMillard.Models
{
    public class Order
    {
        public static readonly decimal[] PaymentSizes = { 0.05m, 0.10m, 0.25m, 1.00m, 5.00m, 10.00m, 20.00m };

        public Order(IRepository<Coffee> coffees, IRepository<Payment> payments, IRepository<Sugar> sugars, IRepository<Cream> creams)
        {
            Coffees = coffees;
            Payments = payments;
            Sugars = sugars;
            Creams = creams;
        }
        /// <summary>
        /// Create and add a new coffee to the order
        /// </summary>
        public Coffee AddCoffee()
        {
            Coffee coffee = null;
            Contract.Ensures(coffee != null);

            coffee = new Coffee(Sugars, Creams);
            Coffees.Add(this, coffee);
            return coffee;
        }
        /// <summary>
        /// Removes a coffee from the order
        /// </summary>
        /// <param name="coffee">The coffee to be removed from the order</param>
        public void RemoveCoffee(Coffee coffee)
        {
            Contract.Requires(coffee != null);

            Coffees.Remove(coffee);
        }
        /// <summary>
        /// Removes all coffees from the order
        /// </summary>
        public void Clear()
        {
            while (Coffees.Count(this) > 0)
            {
                Coffees.Remove(Coffees.Get(null, 0));
            }

            while (Payments.Count(this) > 0)
            {
                Payments.Remove(Payments.Get(null, 0));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>The Total dollar value of all coffees on the order</returns>
        public decimal Total()
        {
            decimal orderTotal = 0.0m;
            foreach (Coffee coffee in Coffees.GetAll(this))
            {
                orderTotal += coffee.Total();
            }
            return orderTotal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>The Total dollar value of all payments on the order</returns>
        public decimal TotalPayments()
        {
            decimal paymentTotal = 0.0m;
            foreach (Payment payment in Payments.GetAll(this))
            {
                paymentTotal += payment.Amount;
            }
            return paymentTotal;
        }

        /// <summary>
        /// Creates and adds a new payment to the order
        /// </summary>
        /// <param name="amount">The amount of the payment</param>
        public Payment AddPayment(decimal amount)
        {
            Payment payment = null;

            Contract.Requires(PaymentSizes.Contains(amount));
            Contract.Ensures(payment != null);

            payment = new Payment();
            payment.Amount = amount;

            Payments.Add(this, payment);
            return payment;
        }

        /// <summary>
        /// Removes a payment from the order
        /// </summary>
        /// <param name="payment">The payment to add to the order</param>
        public void RemovePayment(Payment payment)
        {
            Contract.Requires(payment != null);

            Payments.Remove(payment);
        }
        /// <summary>
        /// Completes the order if it is paid in full
        /// </summary>
        /// <returns>Change due if payments are greater than total owing</returns>
        /// <exception cref="InvalidOperationException">Order not paid in full</exception>
        public decimal CompleteOrder()
        {
            decimal changeDue = TotalPayments() - Total();

            if (changeDue >= 0)
                return changeDue;
            else
                throw new InvalidOperationException("Order cannot be completed until paid in full");
        }

        public IRepository<Coffee> Coffees;
        public IRepository<Payment> Payments;
        public IRepository<Sugar> Sugars;
        public IRepository<Cream> Creams;
    }
}
