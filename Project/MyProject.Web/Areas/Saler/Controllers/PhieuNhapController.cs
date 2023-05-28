using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data.EF;
using MyProject.Data.Entities;
using MyProject.ViewModel;
using Service;
using Service.Implement;
using Service.Interface;
using Service.Repository.Implement;
using System.Data;

namespace MyProject.Web.Areas.Saler.Controllers
{
    [Area("Saler")]
    [Route("saler/[controller]/[action]")]
    [Authorize(Roles = "Saler")]
    public class PhieuNhapController : Controller
    {
        private readonly IPhieuNhapService _phieuNhapService;
        private readonly IChiTietPhieuNhapService _chiTietPNService;

        public PhieuNhapController(IPhieuNhapService phieuNhapService, IChiTietPhieuNhapService chiTietPNService)
        {
            _phieuNhapService = phieuNhapService;
            _chiTietPNService = chiTietPNService;
        }
        public IActionResult Index(int pageNumber)
        {
            var list = _phieuNhapService.GetAllPhieuNhap(pageNumber, 10);
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PhieuNhap phieuNhap, List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            try
            {
                phieuNhap.NgayGiao = DateTime.Now;
                _phieuNhapService.InsertPhieuNhap(phieuNhap);
                foreach(var item in listChiTietPhieuNhap)
                {
                    item.PhieuNhapId = phieuNhap.MaPhieu;
                    item.DVT = "Chiếc";
                    _chiTietPNService.InsertChiTietPhieuNhap(item);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
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
