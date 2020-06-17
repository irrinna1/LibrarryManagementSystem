using System.Collections.Generic;

namespace LibraryManagementSystem.Data.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public Category Category { get; set; }

        public byte[] FrontCover { get; set; }

        public decimal PricePerWeek { get; set; }

        public bool IsTaken { get; set; }

        public IEnumerable<Review> Reviews { get; set; } = new List<Review>();

        public IEnumerable<Rent> Rents { get; set; } = new List<Rent>();
    }
}
