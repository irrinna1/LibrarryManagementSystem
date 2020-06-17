using LibraryManagementSystem.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
       : base(options)
        { }

        public DbSet<Reader> Readers { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookAd> BookAds { get; set; }

        public DbSet<Rent> Rents { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<History> Histories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
