using Microsoft.AspNetCore.Mvc;
using Service.Implement;
using Service.Interface;
using System.Globalization;

namespace MyProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class ReviewController : Controller
    {
        private readonly IReviewsAndWishListService _reviewService;
        private readonly int pageSize;

        public ReviewController(IReviewsAndWishListService reviewService, int pageSize=10)
        {
            _reviewService = reviewService;
            this.pageSize = pageSize;
        }
        public IActionResult Index(int pageNumber)
        {
            var list = _reviewService.GetAllReviews(pageNumber, pageSize, orderBy: p => p.OrderByDescending(x => x.CreateAt) , includeProperties: "User,Product");
            return View(list);
        }

        public IActionResult Delete(int productId, string userId)
        {
            try
            {
                //var model = _shopService.GetShopById(id);
                //model.DeleteAt = DateTime.Now;
                //_shopService.UpDateShop(model);
                _reviewService.Delete(userId, productId);
                return Json(new { result = true });
            }
            catch
            {
                return Json(new { result = false });
            }
        }
    }
}
