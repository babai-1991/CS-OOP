using System;
using CSDemo.InterfaceTestibility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectName.Test
{
    [TestClass]
    public class OrderProcessorTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //MethodName_Condition_Expectation
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalulator());
            var order = new Order()
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ThenShouldSetThisShipmentPropertyOfTheTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalulator());
            var order = new Order();
            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);

            Assert.AreEqual(1.1f,order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1),order.Shipment.ShoppingDate);
        }
    }

    public class FakeShippingCalulator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1.1f;
        }
    }
}
