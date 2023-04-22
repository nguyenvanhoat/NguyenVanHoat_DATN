using Microsoft.AspNetCore.Identity;

namespace MyProject.Data.Entities
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Reviews = new HashSet<Reviews>();
            //WishLists = new HashSet<WishList>();
            //Carts = new HashSet<Cart>();
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
        }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
      
        public ICollection<Reviews> Reviews { get; set; }
        //public ICollection<WishList> WishLists { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}