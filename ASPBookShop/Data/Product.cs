using System.Collections.Generic;

namespace ASPBookShop.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NameAuthorId { get; set; }
        public virtual Author Author { get; set; }
        public Covers Covers { get; set; }
        public Types Types { get; set; }    
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        public int PublishingYear { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int Amount { get; set; }
        public string Summary { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
