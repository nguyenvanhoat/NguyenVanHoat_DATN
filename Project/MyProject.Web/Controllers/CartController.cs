using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data.Entities;
using MyProject.ViewModel;
using Newtonsoft.Json;
using Service.Interface;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using Microsoft.Build.Evaluation;
using Microsoft.AspNetCore.Authorization;

namespace MyProject.Web.Controllers
{
    [AllowAnonymous]
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        public const string CartSession = "CartSession";
        private readonly IUserService _userService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        public CartController(IProductService productService, IUserService userService, UserManager<AppUser> userManager
            , IOrderService orderService, IOrderDetailService orderDetailService)
        {
            _productService = productService;
            _userService = userService;
            _userManager = userManager;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckOut()
        {
            if (HttpContext.Session.GetString(CartSession) == null)
            {
                return Redirect("/gio-hang.html");
            }
            return View();
        }
        public IActionResult CreateOrder(string model)
        {
            try
            {
                var order = JsonConvert.DeserializeObject<OrderDTO>(model);

                order.OrderDate = DateTime.Now;



                var id = _userManager.GetUserId(HttpContext.User);

                if (id == null)
                {
                    return Json(new
                    {
                        status = false
                    });
                }
                order.UserId = id;
                order.Status = "NEW";
                var session = HttpContext.Session.GetString(CartSession);
                List<CartDTO> currentCart = new List<CartDTO>();
                if (session != null)
                {
                    currentCart = JsonConvert.DeserializeObject<List<CartDTO>>(session);
                }
                var c = _orderService.Create(order);
                var orderDetails = new OrderDetailDTO();
                foreach (var item in currentCart)
                {
                    orderDetails.OrderId = c;
                    orderDetails.ProductId = item.ProductId;
                    orderDetails.Quantity = item.Quantity;
                    orderDetails.Price = item.Price;
                    orderDetails.Color = item.Color;
                    _orderDetailService.Create(orderDetails);

                }
                return Json(new
                {
                    status = true
                });
            }
            catch
            {
                throw;
            }

        }

        public UserDTO GetUser()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var user = _userService.GetUserById(userId);
            return user;
        }

        [HttpGet]
        public IActionResult GetListItem()
        {
            var session = HttpContext.Session.GetString(CartSession);
            List<CartDTO> currentCart = new List<CartDTO>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartDTO>>(session);
            }
            return Ok(currentCart);
        }
        public IActionResult AddToCart(int id, string mau, decimal gia)
        {
            var product = _productService.GetProductById(id);
            var session = HttpContext.Session.GetString(CartSession);
            List<CartDTO> currentCart = new List<CartDTO>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartDTO>>(session);
            }
            var cartitem = currentCart.Find(x => x.ProductId == id && x.Color == mau);
            if (cartitem != null)
            {
                return Json(new { result = false });
            }
            else
            {
                var cart = new CartDTO()
                {
                    ProductId = id,
                    Description = product.ProductDetails,
                    Image = product.Thumbnail,
                    Name = product.ProductName,
                    Price = gia,
                    Quantity = 1,
                    Color = mau
                };
                currentCart.Add(cart);
            }
            HttpContext.Session.SetString(CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);

        }

        public IActionResult RemoveItem(int id, string mau)
        {
            var session = HttpContext.Session.GetString(CartSession);
            List<CartDTO> currentCart = new List<CartDTO>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartDTO>>(session);
            }
            foreach (var item in currentCart)
            {
                if (item.ProductId == id)
                {
                    if (item.Color == mau)
                    {
                        currentCart.Remove(item);
                        break;
                    }
                }
            }
            HttpContext.Session.SetString(CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
            //return Json(new { result = true });
        }

        public IActionResult UpdateCart(int id, int quantity)
        {
            var session = HttpContext.Session.GetString(CartSession);
            List<CartDTO> currentCart = new List<CartDTO>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartDTO>>(session);
            }
            foreach (var item in currentCart)
            {
                if (item.ProductId == id)
                {
                    if (quantity == 0)
                    {
                        currentCart.Remove(item);
                        break;
                    }
                    item.Quantity = quantity;
                }
            }
            HttpContext.Session.SetString(CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }
        public IActionResult DeleteAll()
        {
            var session = HttpContext.Session;
            session.Remove(CartSession);
            return Json(new
            {
                status = true
            });
        }

    }
}
