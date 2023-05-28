using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data.Entities;
using MyProject.Data.Enum;
using MyProject.ViewModel;
using Service;
using Service.Implement;
using Service.Interface;
using System.Drawing.Printing;
using System.Linq.Expressions;

namespace MyProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly UserManager<AppUser> _userManager;
        private readonly int pageSize;

        public UserController(IUserService userService, UserManager<AppUser> userManager, int pageSize = 10)
        {
            _userService = userService;
            _userManager = userManager;
            this.pageSize = pageSize;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index(int pageNumber, string searchString, string delete)
        {
            PagedResult<UserDTO> list = new PagedResult<UserDTO>();
            Expression<Func<AppUser, bool>> filter = null;
            Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> sort = sort => sort.OrderByDescending(p => p.CreateAt);

            Func<IQueryable<AppUser>, IQueryable<AppUser>> filterFull = null;
            //IQueryable<AppUser> query;
            ViewBag.SearchString = searchString;
            ViewBag.Delete = delete;

            Expression<Func<AppUser, bool>> filterName = x => x.UserName.Contains("");

            Expression<Func<AppUser, bool>> filterDelete = x => x.UserName.Contains("");

            

            if (delete != null)
            {
                if (delete == "true")
                {
                    filterDelete = x => x.DeleteAt != null;
                }
                else if (delete == "false")
                {
                    filterDelete = x => x.DeleteAt == null;
                }
            }

            

            //Func<IQueryable<Shop>, IQueryable<Shop>> filterName = null;
            if (!String.IsNullOrEmpty(searchString))
            {
                //filter = p => p.ShopName.Contains(searchString);
                filterName = x => x.UserName.Contains(searchString);
            }
            //filterFull = list => query;
            filterFull = list => list.Where(filterName).Where(filterDelete);


            list = _userService.GetAllUser(pageNumber, pageSize, filterFull, orderBy: sort);
            //var list = _userService.GetUser();
            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(UserDTO user)
        {
            try
            {
                var userByName = _userService.GetUser(null, p => p.UserName == user.UserName);
                var userByEmail = _userService.GetUser(null, p => p.Email == user.Email);
                if (userByName.Count() != 0 || userByEmail.Count() != 0)
                {
                    string errorUserName = "";
                    string errorEmail = "";
                    if(userByName.Count() != 0)
                    {
                        errorUserName = "Username đã tồn tại!";
                    }
                    if (userByEmail.Count() != 0)
                    {
                        errorEmail = "Email đã tồn tại!";
                    }
                    return Json(new {result = true, isValid = false, messUsername = errorUserName, messEmail = errorEmail});
                }
                //_userService.InsertUser(user);
                /*AppUser appUser = new AppUser
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    NormalizedUserName = user.UserName.ToUpper(),
                    NormalizedEmail = user.Email.ToUpper(),
                    CreateAt = user.CreateAt
                };*/

                var appUser = new AppUser { UserName = user.UserName, Email = user.Email, CreateAt = DateTime.Now };

                var result = await _userManager.CreateAsync(appUser, user.Password);

                if (result.Succeeded)
                {
                    var currentUser = await _userManager.FindByNameAsync(user.UserName);
                    await _userManager.AddToRoleAsync(currentUser, user.Role);
                }
                return Json(new {result = true, isValid = true });
            }
            catch
            {
                return Json(new { result = false, message = "Đã xảy ra lỗi, vui lòng thử lại sau" });
            }
        }

        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                //var model = _shopService.GetShopById(id);
                //model.DeleteAt = DateTime.Now;
                //_shopService.UpDateShop(model);
                var userUpdate = await _userManager.FindByIdAsync(id);
                userUpdate.DeleteAt = DateTime.Now;
                await _userManager.DeleteAsync(userUpdate);
                return Json(new { result = true });
            }
            catch
            {
                return Json(new { result = false });
            }
        }
    }
}
