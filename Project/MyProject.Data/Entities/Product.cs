using MyProject.Data.Enum;

namespace MyProject.Data.Entities
{
    public class Product
    {
        public Product()
        {
            Medias = new HashSet<Medias>();
            Reviews = new HashSet<Reviews>();
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
            //WishLists = new HashSet<WishList>();
        }
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
        public ICollection<Medias> Medias { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
        public ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        //public ICollection<WishList> WishLists { get; set; }
    }
}