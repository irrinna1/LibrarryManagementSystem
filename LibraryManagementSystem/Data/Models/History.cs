namespace LibraryManagementSystem.Data.Models
{
    public class History
    {
        public int Id { get; set; }

        public int ReaderId { get; set; }

        public virtual Reader Reader { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }


    }
}
