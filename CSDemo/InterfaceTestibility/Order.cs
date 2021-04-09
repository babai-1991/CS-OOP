using System;

namespace CSDemo.InterfaceTestibility
{
    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShipped { get; set; }
        public Shipment Shipment { get; set; }
    }
}