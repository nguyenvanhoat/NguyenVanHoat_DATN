using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data.Entities;
using MyProject.Data.Migrations;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Claims;
using System.Xml.Linq;


namespace MyProject.Web.Controllers
{
    [AllowAnonymous]
    public class LoginManagerController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ILogger<LoginManagerController> _logger;

        public LoginManagerController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ILogger<LoginManagerController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }
        [Route("manager")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            return View();
        }
        [Route("manager")]
        [HttpPost]
        public async Task<IActionResult> Index(InputModel model)
        {

            if (ModelState.IsValid)
            {
                await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);
                //var result = await _signInManager.SignInAsync(user, isPersistent: false);
                if (result.Succeeded)
                {
                    var currentUser = _userManager.Users.FirstOrDefault(u => u.UserName == model.UserName);
                    if (currentUser != null)
                    {
                        var checkRole = await _userManager.IsInRoleAsync(currentUser, "Admin");

                        if (checkRole)
                        {
                            return LocalRedirect("/admin/Home/Index");
                        }
                        var checkRole2 = await _userManager.IsInRoleAsync(currentUser, "Saler");
                        if (checkRole2)
                        {
                            return LocalRedirect("/saler/Home/Index");
                        }
                        return LocalRedirect("/");
                    }
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
            }

            return View();
        }
    }

    public class InputModel
    {
        [Required(ErrorMessage = "UserName không được để trống")]
        //[EmailAddress(ErrorMessage = "Email nhập không đúng định dạng")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        [MaxLength(20, ErrorMessage = "Password chỉ từ 8-20 ký tự")]
        [MinLength(8, ErrorMessage = "Password chỉ từ 8-20 ký tự")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
