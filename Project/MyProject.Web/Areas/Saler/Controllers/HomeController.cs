using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MyProject.Web.Areas.Saler.Controllers
{
    [Authorize(Roles = "Saler")]
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
