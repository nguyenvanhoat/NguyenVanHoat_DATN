using Microsoft.AspNetCore.Mvc;

namespace MyProject.Web.Areas.Saler.Controllers
{
    [Area("Saler")]
    [Route("saler/[controller]/[action]")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
