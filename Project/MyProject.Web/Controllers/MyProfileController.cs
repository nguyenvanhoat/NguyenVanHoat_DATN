using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data.Entities;
using MyProject.ViewModel;
using Service.Interface;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace MyProject.Web.Controllers
{
    public class UserRequest
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Username không được để trống")]
        public string UserName { get; set; }
    }
    public class MyProfileController : Controller
    {
        private readonly IUserService _userService;
        private readonly UserManager<AppUser> _userManage;
        [TempData]
        public string Message { get; set; }

        public MyProfileController(IUserService userService, UserManager<AppUser> userManager)
        {
            _userService = userService;
            _userManage = userManager;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userService.GetUserById(userId);
            var userRequest = new UserRequest
            {
                UserName = user.UserName,
                Email = user.Email,
                Id = user.Id
            };
            return View(userRequest);
        }
        [HttpPost]
        public async Task<IActionResult> ChangeProfile(UserRequest user)
        {
            try
            {
                var userByName = _userService.GetUser(null, p => p.UserName == user.UserName && p.Id != user.Id);
                var userByEmail = _userService.GetUser(null, p => p.Email == user.Email && p.Id != user.Id);
                if (userByName.Count() != 0 || userByEmail.Count() != 0)
                {
                    
                    if (userByName.Count() != 0)
                    {
                        //errorUserName = "Username đã tồn tại!";
                        ModelState.AddModelError(string.Empty, "Username đã tồn tại!");
                        return View("Index");
                    }
                    if (userByEmail.Count() != 0)
                    {
                        ModelState.AddModelError(string.Empty, "Email đã tồn tại!");
                        return View("Index");
                    }
                    //return Json(new { result = true, isValid = false, messUsername = errorUserName, messEmail = errorEmail });
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

                //var appUser = new AppUser { UserName = user.Email, Email = user.Email };

                //var result = await _userManager.CreateAsync(appUser, user.Password);

                //if (result.Succeeded)
                //{
                //    var currentUser = await _userManager.FindByNameAsync(user.Email);
                //    await _userManager.AddToRoleAsync(currentUser, user.Role);
                //}

                if (!ModelState.IsValid)
                {
                    return View("Index");
                }
                
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                //var userUpdate = _userService.GetUserById(userId);
                var userUpdate = await _userManage.FindByIdAsync(userId);
                userUpdate.UserName = user.UserName;
                userUpdate.Email = user.Email;
                userUpdate.UpdateAt = DateTime.Now;
                await _userManage.UpdateAsync(userUpdate);
                Message = "Sửa thành công";
                return RedirectToAction("Index");
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
