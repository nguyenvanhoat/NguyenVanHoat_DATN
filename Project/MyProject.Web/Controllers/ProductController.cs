﻿using Microsoft.AspNetCore.Mvc;
using MyProject.ActionFilter;
using MyProject.ViewModel;
using Service.Implement;
using Service.Interface;
using System.Security.Claims;

namespace MyProject.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IReviewsAndWishListService _reviewsAndWishListService;

        public ProductController(IProductService productService, IReviewsAndWishListService reviewsAndWishListService)
        {
            _productService = productService;
            _reviewsAndWishListService = reviewsAndWishListService;
        }

        [ServiceFilter(typeof(AddViewFilter))]
        public IActionResult Index(int id)
        {
            try
            {
                var product = _productService.GetProduct(null, x => x.Id == id, null, "Shop").FirstOrDefault();
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                //product.Views++;
                //_productService.UpDateProduct(product);
                //ViewBag.Id = id;
                if (userId != null)
                {
                    _reviewsAndWishListService.Viewed(userId, id);
                }
                return View(product);
            }
            catch
            {
                return NotFound();
            }
        }

        public IActionResult AddReview(string review, int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if(userId == null)
            {
                return Json(new { result = false , mess = "Bạn Chưa Đăng nhập"});
            }
            try
            {
                var reviewModel = _reviewsAndWishListService.GetReviewById(userId, id);

                reviewModel.CreateAt = DateTime.Now;
                reviewModel.ReviewsDetails = review;
                _reviewsAndWishListService.UpDateReview(reviewModel);
                return Json(new { result = "ok" });
            }
            catch
            {
                return Json(new { result = false, mess = "Lỗi!" });
            }
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
                
                _reviewsAndWishListService.AddWishList(userId, id);
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

                _reviewsAndWishListService.RemoveWishList(userId, id);
                return Json(new { result = "ok" });
            }
            catch
            {
                return Json(new { result = false, mess = "Lỗi!" });
            }
        }
    }
}