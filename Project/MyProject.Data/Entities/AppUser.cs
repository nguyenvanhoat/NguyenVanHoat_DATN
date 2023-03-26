using Microsoft.AspNetCore.Identity;

namespace MyProject.Data.Entities
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Shops = new HashSet<Shop>();
            Reviews = new HashSet<Reviews>();
            //WishLists = new HashSet<WishList>();    
        }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
      
        public ICollection<Shop> Shops{ get; set; }
        public ICollection<Reviews> Reviews { get; set; }
        //public ICollection<WishList> WishLists { get; set; }
    }
}