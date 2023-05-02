using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data.EF;
using PrintService.Interface;
using Service.Implement;
using Service.Interface;
using System.Data;

namespace MyProject.Web.Areas.Saler.Controllers
{
    [Area("Saler")]
    [Route("saler/[controller]/[action]")]
    [Authorize(Roles = "Saler")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly AppDbContext _context;
        private readonly IPrintService _printService;

        public OrderController(IOrderService datLichService, AppDbContext context, IPrintService printService)
        {
            _orderService = datLichService;
            _context = context;
            _printService = printService;
        }
        public IActionResult Index(int pageNumber)
        {
            var list = _orderService.GetAllOrder(pageNumber, 10, orderBy: x => x.OrderByDescending(p => p.OrderDate));
            return View(list);
        }

        [HttpPost]
        public IActionResult Print(int id)
        {
            _printService.Print(id);
            TempData["Contain"] = "Contain";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult XacNhan(int id)
        {
            var item = _context.Orders.Where(x => x.Id == id).FirstOrDefault();
            if(item != null)
            {
                item.Status = "Đã xử lý";
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
