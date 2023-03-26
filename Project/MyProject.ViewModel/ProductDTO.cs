using Microsoft.AspNetCore.Http;
using MyProject.Data.Entities;
using MyProject.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ViewModel
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Slug { get; set; }
        public string ProductDetails { get; set; }
        public decimal Price { get; set; }
        public bool Trending { get; set; }
        public bool Status { get; set; }
        public int Views { get; set; }
        public string Thumbnail { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public List<Shop> ListShop{ get; set; }
        public IFormFile File { get; set; }
    }
}
