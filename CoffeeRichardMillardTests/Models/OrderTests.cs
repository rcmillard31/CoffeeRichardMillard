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
    public class OrderTests
    {
        [TestMethod()]
        public void OrderTest()
        {
            InMemoryRepository<Coffee> coffees = new InMemoryRepository<Coffee>();
            InMemoryRepository<Payment> payments = new InMemoryRepository<Payment>();
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Order order = new Order(coffees, payments, sugars, creams);

            Assert.IsNotNull(order);
            Assert.IsNotNull(order.Coffees);
            Assert.IsNotNull(order.Payments);
        }

        [TestMethod()]
        public void AddCoffeeTest()
        {
            InMemoryRepository<Coffee> coffees = new InMemoryRepository<Coffee>();
            InMemoryRepository<Payment> payments = new InMemoryRepository<Payment>();
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Order order = new Order(coffees, payments, sugars, creams);
            Coffee coffee = order.AddCoffee();
            Assert.IsNotNull(coffee);
        }

        [TestMethod()]
        public void RemoveCoffeeTest()
        {
            InMemoryRepository<Coffee> coffees = new InMemoryRepository<Coffee>();
            InMemoryRepository<Payment> payments = new InMemoryRepository<Payment>();
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Order order = new Order(coffees, payments, sugars, creams);
            Coffee coffee = order.AddCoffee();

            order.RemoveCoffee(coffee);
            Assert.IsTrue(order.Coffees.Count(order) == 0);
        }

        [TestMethod()]
        public void ClearTest()
        {
            InMemoryRepository<Coffee> coffees = new InMemoryRepository<Coffee>();
            InMemoryRepository<Payment> payments = new InMemoryRepository<Payment>();
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Order order = new Order(coffees, payments, sugars, creams);
            order.AddCoffee();
            order.AddPayment(Order.PaymentSizes[0]);

            order.Clear();

            Assert.IsTrue(order.Total() == 0.0m);
            Assert.IsTrue(order.TotalPayments() == 0.0m);
        }

        [TestMethod()]
        public void TotalTest()
        {
            InMemoryRepository<Coffee> coffees = new InMemoryRepository<Coffee>();
            InMemoryRepository<Payment> payments = new InMemoryRepository<Payment>();
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Order order = new Order(coffees, payments, sugars, creams);
            Coffee coffee = order.AddCoffee();
            coffee.Size = CoffeeSizes.Large;
            coffee.AddSugar();
            coffee.AddCream();

            Assert.IsTrue(order.Total() == (Coffee.PriceForLarge + Cream.PriceForCream + Sugar.PriceForSugar));
        }

        [TestMethod()]
        public void TotalPaymentsTest()
        {
            InMemoryRepository<Coffee> coffees = new InMemoryRepository<Coffee>();
            InMemoryRepository<Payment> payments = new InMemoryRepository<Payment>();
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Order order = new Order(coffees, payments, sugars, creams);

            Assert.AreEqual(0.0m, order.TotalPayments(), "No Payments applied, total should be zero");

            order.AddPayment(Order.PaymentSizes[0]);
            order.AddPayment(Order.PaymentSizes[1]);

            Assert.AreEqual(Order.PaymentSizes[0] + Order.PaymentSizes[1], order.TotalPayments());
        }

        [TestMethod()]
        public void AddPaymentTest()
        {
            InMemoryRepository<Coffee> coffees = new InMemoryRepository<Coffee>();
            InMemoryRepository<Payment> payments = new InMemoryRepository<Payment>();
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Order order = new Order(coffees, payments, sugars, creams);
            Payment payment = order.AddPayment(Order.PaymentSizes[0]);
            Assert.IsNotNull(payment);
        }

        [TestMethod()]
        public void RemovePaymentTest()
        {
            InMemoryRepository<Coffee> coffees = new InMemoryRepository<Coffee>();
            InMemoryRepository<Payment> payments = new InMemoryRepository<Payment>();
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Order order = new Order(coffees, payments, sugars, creams);
            Payment payment = order.AddPayment(Order.PaymentSizes[0]);
            order.RemovePayment(payment);

            Assert.IsTrue(order.Payments.Count(order) == 0);
        }

        [TestMethod()]
        public void CompleteOrderTest()
        {
            InMemoryRepository<Coffee> coffees = new InMemoryRepository<Coffee>();
            InMemoryRepository<Payment> payments = new InMemoryRepository<Payment>();
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Order order = new Order(coffees, payments, sugars, creams);
            Coffee coffee = order.AddCoffee();
            coffee.Size = CoffeeSizes.Large;
            order.AddPayment(Order.PaymentSizes[Order.PaymentSizes.Length - 1]);

            decimal changeDue = order.CompleteOrder();
            Assert.AreEqual(order.TotalPayments() - order.Total(), changeDue);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CompleteOrderWithoutPaymentTest()
        {
            InMemoryRepository<Coffee> coffees = new InMemoryRepository<Coffee>();
            InMemoryRepository<Payment> payments = new InMemoryRepository<Payment>();
            InMemoryRepository<Sugar> sugars = new InMemoryRepository<Sugar>();
            InMemoryRepository<Cream> creams = new InMemoryRepository<Cream>();

            Order order = new Order(coffees, payments, sugars, creams);
            Coffee coffee = order.AddCoffee();
            coffee.Size = CoffeeSizes.Large;

            order.CompleteOrder();
        }
    }
}