using Microsoft.AspNetCore.Mvc;
using MyProject.Data.EF;
using Service.Implement;
using Service.Interface;
using System.Threading.Tasks.Dataflow;

namespace MyProject.Web.Areas.Saler.Controllers
{
    [Area("Saler")]
    [Route("saler/[controller]/[action]")]
    public class LichHenController : Controller
    {
        private readonly IDatLichService _datLichService;
        private readonly AppDbContext _context;

        public LichHenController(IDatLichService datLichService, AppDbContext context)
        {
            _datLichService = datLichService;
            _context = context;
        }
        public IActionResult Index(int pageNumber)
        {
            var list = _datLichService.GetAllDatLich(pageNumber, 10, orderBy: x => x.OrderBy(p => p.NgayHen));
            return View(list);
        }

        #region API
        public JsonResult GetDetailsLichHen(int id)
        {
            try
            {
                var model = _context.DatLiches.Find(id);
                return Json(model);
            }
            catch(Exception e)
            {
                throw;
            }
        }

        public JsonResult LienHe(int id, DateTime ngayHen, string ghiChu)
        {
            try
            {
                var lichHen = _context.DatLiches.Find(id);
                if(lichHen == null)
                {
                    return Json(new { result = false });
                }

                lichHen.NgayHen = ngayHen;
                lichHen.GhiChu = ghiChu ?? "";
                lichHen.TrangThai = "1";

                _context.SaveChanges();

                return Json(new { result = true });
            }
            catch
            {
                throw;
            }
        }

        public JsonResult ThanhCong(int id)
        {
            try
            {
                var lichHen = _context.DatLiches.Find(id);
                if (lichHen == null)
                {
                    return Json(new { result = false });
                }

                lichHen.TrangThai = "2";

                _context.SaveChanges();

                return Json(new { result = true });
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
