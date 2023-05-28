using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Web.Areas.Saler.Controllers
{
    [Authorize(Roles = "Saler")]
    public class BaoHanhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
