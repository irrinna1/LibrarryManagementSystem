using System;

namespace LibraryManagementSystem.Data.Models
{
    public class Rent
    {
        public int Id { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public decimal Price { get; set; }

        public int ReaderId { get; set; }

        public virtual Reader Reader { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
