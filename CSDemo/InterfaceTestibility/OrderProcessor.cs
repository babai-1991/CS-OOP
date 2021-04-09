using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.InterfaceTestibility
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;

        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("Order is already shipped");
            }

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShoppingDate = DateTime.Now.AddDays(1)

            };
        }
    }
}
