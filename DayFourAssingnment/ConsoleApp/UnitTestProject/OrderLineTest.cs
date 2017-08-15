using System;
using System.Diagnostics;
using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class OrderLineTest
    {
        [TestMethod]
        public void SampleOrderLineTest()
        {
            OrderLine apple = new OrderLine(quantity: 1, unitPrice: 20m, discount: 0.0f);

            Assert.IsNotNull(apple);
            Assert.IsNotNull(apple.Total);
            Assert.AreEqual(1,apple.Quantity);
            Assert.AreEqual(0.0f, apple.Discount);
            Assert.AreEqual(20m, apple.UnitPrice);

            Debug.WriteLine("Total price of Apple orderline : {0}", apple.Total);
            Assert.AreEqual(20m, apple.Total);

        }

        [TestMethod]
        public void WithDiscountTest()
        {
            OrderLine apple = new OrderLine(quantity: 1, unitPrice: 20m, discount: 0.0f);

            Assert.IsNotNull(apple);
            Assert.IsNotNull(apple.Total);

            Assert.AreEqual(1, apple.Quantity);
            Assert.AreEqual(0.0f, apple.Discount);
            Assert.AreEqual(20m, apple.UnitPrice);

            Debug.WriteLine("Total price of Apple orderline : {0}", apple.Total);

            apple = apple.WithDiscount(0.5f);

            Assert.AreEqual(1, apple.Quantity);
            Assert.AreEqual(0.5f, apple.Discount);
            Assert.AreEqual(20m, apple.UnitPrice);

            Debug.WriteLine("Total price after 0.5f discont on Apple orderline : {0}", apple.Total);

            Assert.AreEqual(10m, apple.Total);
        }

        [TestMethod]
        public void WithQuantityTest()
        {
            OrderLine apple = new OrderLine(quantity: 1, unitPrice: 20m, discount: 0.0f);

            Assert.IsNotNull(apple);
            Assert.IsNotNull(apple.Total);

            Assert.AreEqual(1, apple.Quantity);
            Assert.AreEqual(0.0f, apple.Discount);
            Assert.AreEqual(20m, apple.UnitPrice);

            Debug.WriteLine("Total price of Apple orderline : {0}", apple.Total);

            apple = apple.WithQuantity(5);

            Assert.AreEqual(5, apple.Quantity);
            Assert.AreEqual(0.0f, apple.Discount);
            Assert.AreEqual(20m, apple.UnitPrice);

            Debug.WriteLine("Total price of Apple orderline with quantity 5 : {0}", apple.Total);

            Assert.AreEqual(100m, apple.Total);
        }

        [TestMethod]
        public void WithUnitPriceTest()
        {
            OrderLine apple = new OrderLine(quantity: 1, unitPrice: 20m, discount: 0.0f);

            Assert.IsNotNull(apple);
            Assert.IsNotNull(apple.Total);

            Assert.AreEqual(1, apple.Quantity);
            Assert.AreEqual(0.0f, apple.Discount);
            Assert.AreEqual(20m, apple.UnitPrice);

            Debug.WriteLine("Total price of Apple orderline : {0}", apple.Total);

            Assert.AreEqual(20m, apple.Total);

            apple = apple.WithUnitPrice(50);

            Assert.AreEqual(1, apple.Quantity);
            Assert.AreEqual(0.0f, apple.Discount);
            Assert.AreEqual(50m, apple.UnitPrice);

            Debug.WriteLine("New price of Apple orderline : {0}", apple.Total);

            Assert.AreEqual(50m, apple.Total);
        }
    }
}
