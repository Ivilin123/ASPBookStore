using System.Collections.Generic;

namespace ASPBookShop.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public Roles Roles { get; set; }            
        public virtual ICollection<Order> Orders { get; set; }

    }
}
