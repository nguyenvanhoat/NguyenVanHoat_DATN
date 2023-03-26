using MyProject.Data.Entities;
using MyProject.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Humanizer.On;

namespace MyProject.ViewModel
{
    public class ShopDTO
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string Slug { get; set; }
        public bool Trending { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public string UserId { get; set; }
        public IEnumerable<AppUser> ListUser = new List<AppUser>();
    }
}
