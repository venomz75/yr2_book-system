using System;

namespace BookClasses
{
    public class clsOrder
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DatePlaced { get; set; }
        public bool Completed { get; set; }
        public string OrderStatus { get; set; }
    }
}