using Microsoft.AspNetCore.Mvc;
using MyProject.Data.EF;
using MyProject.Data.Entities;
using Service.Implement;
using Service.Interface;
using Service.Repository.Implement;

namespace MyProject.Web.Areas.Saler.Controllers
{
    [Area("Saler")]
    [Route("saler/[controller]/[action]")]
    public class PhieuNhapController : Controller
    {
        private readonly IPhieuNhapService _phieuNhapService;
        private readonly IChiTietPhieuNhapService _chiTietPNService;

        public PhieuNhapController(IPhieuNhapService phieuNhapService, IChiTietPhieuNhapService chiTietPNService)
        {
            _phieuNhapService = phieuNhapService;
            _chiTietPNService = chiTietPNService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(PhieuNhap phieuNhap, List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            try
            {
                _phieuNhapService.InsertPhieuNhap(phieuNhap);
                foreach(var item in listChiTietPhieuNhap)
                {
                    _chiTietPNService.InsertChiTietPhieuNhap(item);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                throw;
            }
        }

        public IActionResult Details(int id)
        {
            try
            {
                PhieuNhap phieuNhap = _phieuNhapService.GetPhieuNhapById(id);
                if(phieuNhap == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(phieuNhap);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
