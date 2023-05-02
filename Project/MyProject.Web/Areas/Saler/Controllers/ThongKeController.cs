using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MyProject.Web.Areas.Saler.Controllers
{
    [Area("Saler")]
    [Route("saler/[controller]/[action]")]
    [Authorize(Roles = "Saler")]
    public class ThongKeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
