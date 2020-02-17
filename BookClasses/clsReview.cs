using System;

namespace BookClasses
{
    public class clsReview
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int ReviewNo { get; set; }
        public string ReviewerName { get; set; }
        public int Star { get; set; }
        public bool WouldUse { get; set; }
    }
}