using System;

namespace BookClasses
{
    public class clsBook
    {
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public bool AvailableOnline { get; set; }
    }
}