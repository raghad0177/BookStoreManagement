using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Models
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }

    }
}
