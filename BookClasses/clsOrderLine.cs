namespace BookClasses
{
    public class clsOrderLine
    {
        public int OrderLineID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
    }
}