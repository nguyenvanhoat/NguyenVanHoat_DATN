using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrintService.Interface;
using System.Data;

namespace MyProject.Web.Areas.Saler.Controllers
{
    [Area("Saler")]
    [Route("saler/[controller]/[action]")]
    [Authorize(Roles = "Saler")]
    public class ThongKeController : Controller
    {
        private readonly IPrintService _printService;
        public ThongKeController(IPrintService printService)
        {
            _printService = printService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BaoCao(DateTime start, DateTime end)
        {
            _printService.PrintBaoCao(start, end);
            TempData["Xuat"] = "true";
            return RedirectToAction("Index");
        }
    }
}
