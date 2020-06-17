using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Data.Models
{
    public class Reader
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public int CardNumberId { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public IEnumerable<Review> Reviews { get; set; } = new List<Review>();
    }
}
