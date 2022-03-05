using System.Collections.Generic;

namespace ASPBookShop.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
