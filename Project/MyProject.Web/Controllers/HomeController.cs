using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data.EF;
using MyProject.Data.Entities;
using MyProject.ViewModel;
using MyProject.Web.Models;
using Service;
using Service.Implement;
using Service.Interface;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq.Expressions;
using System.Security.Claims;

namespace MyProject.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IReviewsAndWishListService _reviewService;
        private readonly IProductService _productService;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, IReviewsAndWishListService reviewService, IProductService productService, AppDbContext context)
        {
            _logger = logger;
            _reviewService = reviewService;
            _productService = productService;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult MyWishList()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var list = _reviewService.GetReview(filter: p => p.UserId == userId && p.IsWishList == true, includeProperties: "Product");
            return View(list);
        }

        public IActionResult AddWishList(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Json(new { result = false, mess = "Bạn Chưa Đăng nhập" });
            }
            try
            {

                _reviewService.AddWishList(userId, id);
                return Json(new { result = "ok" });
            }
            catch
            {
                return Json(new { result = false, mess = "Lỗi!" });
            }
        }

        public IActionResult RemoveWishList(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Json(new { result = false, mess = "Bạn Chưa Đăng nhập" });
            }
            try
            {

                _reviewService.RemoveWishList(userId, id);
                return Json(new { result = "ok" });
            }
            catch
            {
                return Json(new { result = false, mess = "Lỗi!" });
            }
        }

        public IActionResult MyReview() 
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var list = _reviewService.GetReview(filter: p => p.UserId == userId && p.DeleteAt == null && p.ReviewsDetails != null, includeProperties: "User,Product");
            return View(list);
        }

        public IActionResult GetReview(int productId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            try
            {
                var review = _reviewService.GetReviewById(userId, productId);
                return Json(new { review = review.ReviewsDetails });
            }
            catch
            {
                return Json(new {review = false});
            }
        }

        
        public IActionResult EditReview(int productId, string review)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            try
            {
                var model = _reviewService.GetReviewById(userId, productId);
                model.ReviewsDetails = review;
                model.UpdateAt = DateTime.Now;
                _reviewService.UpDateReview(model);
                return Json(new { result = true });
            }
            catch
            {
                return Json(new { result = false });
            }
        }

        public IActionResult Product(int pageNumber, string trending, int? min, int? max, string searchString, int? shopId)
        {
            int pageSize = 12;
            PagedResult<ProductDTO> list = new PagedResult<ProductDTO>();
            Func<IQueryable<Product>, IQueryable<Product>> filterFull = null;
            Expression<Func<Product, bool>> filterShop = null;
            Func<IQueryable<Product>, IOrderedQueryable<Product>> sort = sort => sort.OrderByDescending(p => p.Views);
            if (shopId != null)
            {
                ViewBag.ShopId = shopId;
                filterShop = p => p.ShopId == shopId;
            }
            //IQueryable<Product> query;
            ViewBag.SearchString = searchString;
            ViewBag.Shop = shopId;
            ViewBag.Trending = trending;
            ViewBag.Min = min;
            ViewBag.Max = max;

            Expression<Func<Product, bool>> filterName = x => x.ProductName.Contains("");

            Expression<Func<Product, bool>> filterPrice = x => x.ProductName.Contains("");

            Expression<Func<Product, bool>> filterTrending = x => x.ProductName.Contains("");

            if(min != null && max != null && min <= max)
            {
                filterPrice = p => p.Price >= min && p.Price <= max;
            }
            
            if (trending != null)
            {
                if (trending == "true")
                {
                    filterTrending = x => x.Trending == true;
                }
                else if (trending == "false")
                {
                    filterTrending = x => x.Trending == false;
                }
            }

            //Func<IQueryable<Product>, IQueryable<Product>> filterName = null;
            if (!String.IsNullOrEmpty(searchString))
            {
                //filter = p => p.ProductName.Contains(searchString);
                filterName = x => x.ProductName.Contains(searchString);
            }
            //filterFull = list => query;
            filterFull = list => list.Where(filterName).Where(filterTrending).Where(filterPrice);


            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    filter = p => p.ProductName.Contains(searchString);
            //}

            //list = _productService.GetAllProduct(pageNumber, pageSize, null, filter, null, "Product");
            //var list = _userService.GetUser();
            //var list = _shopService.GetShop();
            //return View(list);
            try
            {
                list = _productService.GetAllProduct(pageNumber, pageSize, filterFull, filter: filterShop, orderBy: sort, "Shop");
                return View(list);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        public IActionResult SanPhamMua()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var list = _context.Orders.Where(x => x.UserId == userId).ToList();
            return View(list);
        }

        public IActionResult ChiTietSanPham(int orderId)
        {
            var list = _context.OrderDetails.Where(x => x.OrderId == orderId).ToList();
            return Json(list);
        }
    }
}