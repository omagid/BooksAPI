using Books.Data;
using Microsoft.EntityFrameworkCore;

namespace Books.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
