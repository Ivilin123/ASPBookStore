using System;

namespace ASPBookShop.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int AmountOrdered { get; set; }
        public decimal PriceOrder { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
