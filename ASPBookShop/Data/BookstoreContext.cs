using Microsoft.EntityFrameworkCore;

namespace ASPBookShop.Data
{
    public class BookstoreContext:DbContext
    {
        public BookstoreContext()
        {

        }
        public BookstoreContext(DbContextOptions<BookstoreContext> options) :
           base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
    }

}

