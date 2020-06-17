namespace LibraryManagementSystem.Data.Models
{
    public class BookAd
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
