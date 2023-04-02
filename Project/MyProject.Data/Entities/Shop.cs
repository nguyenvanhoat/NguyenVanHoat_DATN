using MyProject.Data.Enum;

namespace MyProject.Data.Entities
{
    public class Shop
    {
        public Shop()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string Slug { get; set; }
        public bool Trending { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}