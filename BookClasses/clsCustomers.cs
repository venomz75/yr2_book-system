using System;

namespace BookClasses
{
    public class clsCustomers
    {
        public DateTime DateAdded { get; set; }
        public int CustomerID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public bool PremiumMember { get; set; }
        public string Password { get; set; }
    }
}