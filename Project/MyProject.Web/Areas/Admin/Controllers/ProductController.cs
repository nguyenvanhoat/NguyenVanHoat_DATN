using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data.EF;
using MyProject.Data.Entities;
using MyProject.Data.Enum;
using MyProject.Utilities.Helper;
using MyProject.ViewModel;
using Service;
using Service.Implement;
using Service.Interface;
using System.Data;
using System.Drawing.Printing;
using System.Linq.Expressions;

namespace MyProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IMediasService _mediasService;
        private readonly IShopService _shopServcie;
        private readonly IProductService _productService;
        private readonly int pageSize;
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext ,IProductService productService, IShopService shopService, IMediasService mediasService ,int pageSize = 10)
        {
            _mediasService = mediasService;
            _shopServcie = shopService;
            _productService = productService;
            this.pageSize = pageSize;
            _appDbContext = appDbContext;
        }
        public IActionResult Index(int pageNumber, string trending, string delete, string searchString, int? shopId)
        {
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
            ViewBag.Delete = delete;
            ViewBag.Trending = trending;

            Expression<Func<Product, bool>> filterName = x => x.ProductName.Contains("");

            Expression<Func<Product, bool>> filterDelete = x => x.ProductName.Contains("");

            Expression<Func<Product, bool>> filterTrending = x => x.ProductName.Contains("");

            if (delete != null)
            {
                if (delete == "true")
                {
                    filterDelete = x => x.DeleteAt != null;
                }
                else if (delete == "false")
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

            //Func<IQueryable<Product>, IQueryable<Product>> filterName = null;
            if (!String.IsNullOrEmpty(searchString))
            {
                //filter = p => p.ProductName.Contains(searchString);
                filterName = x => x.ProductName.Contains(searchString);
            }
            //filterFull = list => query;
            filterFull = list => list.Where(filterName).Where(filterDelete).Where(filterTrending);


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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductDTO model)
        {
            try
            {
                var productByShopName = _productService.GetProduct(null, p => p.ProductName == model.ProductName);
                if (productByShopName.Count() != 0)
                {
                    string errorShopName = "ProductName đã tồn tại";
                    return Json(new { result = true, isValid = false, messProductname = errorShopName });
                }
                model.Slug = Helper.ToUrlSlug(model.ProductName);

                var shopBySlug = _productService.GetProduct(null, p => p.Slug == model.Slug);
                if (shopBySlug.Count() != 0)
                {
                    string errorSlug = "Slug đã tồn tại, vui lòng chọn ShopName khác";
                    return Json(new { result = true, isValid = false, messSlug = errorSlug });
                }

                //var shop = new ProductDTO().ConvertViewModel(model);
                var id = _productService.InsertProduct(model);
                MediasDTO medias = new MediasDTO
                {
                    ProductId = id,
                    File = model.File
                };
                _mediasService.InsertMedias(medias);
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
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(ProductDTO model)
        {
            try
            {
                var productByShopName = _productService.GetProduct(null, p => p.ProductName == model.ProductName && p.Id != model.Id);
                if (productByShopName.Count() != 0)
                {
                    string errorShopName = "ProductName đã tồn tại";
                    return Json(new { result = true, isValid = false, messProductname = errorShopName });
                }
                model.Slug = Helper.ToUrlSlug(model.ProductName);

                var shopBySlug = _productService.GetProduct(null, p => p.Slug == model.Slug && p.Id != model.Id);
                if (shopBySlug.Count() != 0)
                {
                    string errorSlug = "Slug đã tồn tại, vui lòng chọn ShopName khác";
                    return Json(new { result = true, isValid = false, messSlug = errorSlug });
                }

                //var shop = new ProductDTO().ConvertViewModel(model);
                var updateProduct = _productService.GetProductById(model.Id);
                updateProduct.ProductName = model.ProductName;
                updateProduct.Slug = model.Slug;
                updateProduct.ProductDetails = model.ProductDetails;
                updateProduct.Price = model.Price;
                updateProduct.Trending = model.Trending;
                updateProduct.UpdateAt = DateTime.Now;
                _productService.UpDateProduct(updateProduct);

                return Json(new { result = true, isValid = true });
            }
            catch
            {
                return Json(new { result = false, message = "Đã xảy ra lỗi, vui lòng thử lại sau" });
            }
        }

        public IActionResult Image(int id)
        {
            var photos = _mediasService.GetMedias(null, p => p.ProductId == id);
            ViewBag.Id = id;
            return View(photos);
        }

        public IActionResult UpLoadImage(MediasDTO model)
        {
            try
            {
                _mediasService.InsertMedias(model);
                return Json(new { result = true });
            }
            catch
            {
                return Json(new { result = false });
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                var model = _productService.GetProductById(id);
                //model.DeleteAt = DateTime.Now;
                //_shopService.UpDateShop(model);
                _productService.DeleteProduct(model);
                return Json(new { result = true });
            }
            catch
            {
                return Json(new { result = false });
            }
        }

        [HttpGet]
        public JsonResult GetListGia(int id)
        {
            try
            {
                return Json(_appDbContext.GiaXes.Where(x => x.ProductId == id).ToList());
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        public JsonResult GetGiaById(int id)
        {
            try
            {
                var listGia = _appDbContext.GiaXes.Where(x => x.ProductId == id).ToList();
                return Json(listGia);
            }
            catch
            {
                throw;
            }
        }

        public JsonResult ThemGia(GiaXe model)
        {
            var compare = _appDbContext.GiaXes.Where(x => x.MauXe.ToLower() == model.MauXe.ToLower() && x.ProductId == model.ProductId).ToList();
            if (compare.Count() != 0)
            {
                return Json(new { result = false });
            }
            _appDbContext.GiaXes.Add(model);
            _appDbContext.SaveChanges();
            return Json(new { result = true });
        }
    }
}
