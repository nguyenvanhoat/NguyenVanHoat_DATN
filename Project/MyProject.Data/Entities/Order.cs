using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string? UserId { get; set; }
        public string Address { set; get; }
        public string PhoneNumber { set; get; }
        public string Type { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public AppUser? User { get; set; }
    }
}
