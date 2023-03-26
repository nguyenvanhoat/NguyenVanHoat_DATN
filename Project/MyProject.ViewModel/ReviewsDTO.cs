using MyProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ViewModel
{
    public class ReviewsDTO
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public bool Viewd { get; set; }
        public bool IsWishList { get; set; }
        public string ReviewsDetails { get; set; }
        public DateTime DateView { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public AppUser User { get; set; }
        public Product Product { get; set; }
    }
}
