using System.Collections.Generic;

namespace ASPBookShop.Data
{
    public class Publisher
    {
        public int Id { get; set; }
        public string NamePublisher { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
