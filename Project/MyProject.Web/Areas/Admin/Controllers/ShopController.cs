using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data.Entities;
using MyProject.Utilities.Helper;
using MyProject.ViewModel;
using Service;
using Service.Interface;
using System.Drawing.Printing;
using System.Linq.Expressions;

namespace MyProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class ShopController : Controller
    {
        private readonly int pageSize;
        private readonly IShopService _shopService;
        private readonly IUserService _userService;

        public ShopController(IShopService shopService, IUserService userService, int pageSize = 10)
        {
            this.pageSize = pageSize;
            _shopService = shopService;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index(int pageNumber, string trending, string delete, string searchString)
        {
            PagedResult<ShopDTO> list = new PagedResult<ShopDTO>();
            Func<IQueryable<Shop>, IQueryable<Shop>> filterFull = null;
            Func<IQueryable<Shop>, IOrderedQueryable<Shop>> sort = sort => sort.OrderByDescending(p => p.CreateAt);
            //IQueryable<Shop> query;
            ViewBag.SearchString = searchString;
            ViewBag.Delete = delete;
            ViewBag.Trending = trending;

            Expression<Func<Shop, bool>> filterName = x=>x.ShopName.Contains("");

            Expression<Func<Shop, bool>> filterDelete = x => x.ShopName.Contains("");

            Expression<Func<Shop, bool>> filterTrending = x => x.ShopName.Contains("");

            if (delete != null)
            {
                if(delete == "true")
                {
                    filterDelete = x => x.DeleteAt != null;
                }
                else if(delete == "false")
                {
                    filterDelete = x => x.DeleteAt == null;
                }
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

            //Func<IQueryable<Shop>, IQueryable<Shop>> filterName = null;
            if (!String.IsNullOrEmpty(searchString))
            {
                //filter = p => p.ShopName.Contains(searchString);
                filterName = x => x.ShopName.Contains(searchString);
            }
            //filterFull = list => query;
            filterFull = list => list.Where(filterName).Where(filterDelete).Where(filterTrending);

            try
            {
                list = _shopService.GetAllShop(pageNumber, pageSize, filterFull, orderBy: sort);
                return View(list);
            }
            catch(Exception ex)
            {
                return NotFound();
            }
            //var list = _userService.GetUser();
            //var list = _shopService.GetShop();
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ShopDTO model)
        {
            try
            {
                var shopByShopName = _shopService.GetShop(null, p => p.ShopName == model.ShopName);
                if (shopByShopName.Count() != 0)
                {
                    string errorShopName = "ShopName đã tồn tại";
                    return Json(new { result = true, isValid = false, messShopname = errorShopName});
                }
                model.Slug = Helper.ToUrlSlug(model.ShopName);

                var shopBySlug = _shopService.GetShop(null, p => p.Slug == model.Slug);
                if (shopBySlug.Count() != 0)
                {
                    string errorSlug = "Slug đã tồn tại, vui lòng chọn ShopName khác";
                    return Json(new { result = true, isValid = false, messSlug = errorSlug });
                }

                _shopService.InsertShop(model);
                return Json(new { result = true, isValid = true });
            }
            catch
            {
                return Json(new { result = false, message = "Đã xảy ra lỗi, vui lòng thử lại sau" });
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var shop = _shopService.GetShopById(id);
            return View(shop);
        }

        [HttpPost]
        public IActionResult Edit(ShopDTO model)
        {
            try
            {
                var shopByShopName = _shopService.GetShop(null, p => p.ShopName == model.ShopName && p.Id != model.Id);
                if (shopByShopName.Count() != 0)
                {
                    string errorShopName = "ShopName đã tồn tại";
                    return Json(new { result = true, isValid = false, messShopname = errorShopName });
                }
                model.Slug = Helper.ToUrlSlug(model.ShopName);

                var shopBySlug = _shopService.GetShop(null, p => p.Slug == model.Slug && p.Id != model.Id);
                if (shopBySlug.Count() != 0)
                {
                    string errorSlug = "Slug đã tồn tại, vui lòng chọn ShopName khác";
                    return Json(new { result = true, isValid = false, messSlug = errorSlug });
                }
                var updateShop = _shopService.GetShopById(model.Id);
                updateShop.ShopName = model.ShopName;
                updateShop.Trending = model.Trending;
                updateShop.UpdateAt = DateTime.Now;
                updateShop.UserId = model.UserId;
                updateShop.Slug = model.Slug;
                _shopService.UpDateShop(updateShop);
                return Json(new { result = true, isValid = true });
            }
            catch
            {
                return Json(new { result = false, message = "Đã xảy ra lỗi, vui lòng thử lại sau" });
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                //var model = _shopService.GetShopById(id);
                //model.DeleteAt = DateTime.Now;
                //_shopService.UpDateShop(model);
                _shopService.DeleteShopStatus(id);
                return Json(new { result = true });
            }
            catch
            {
                return Json(new { result = false });
            }
        }
    }
}
