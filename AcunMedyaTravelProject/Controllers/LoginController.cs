using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AcunMedyaTravelProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var checkUser = _context.Admins.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            if (checkUser != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,model.Username),
                    new Claim(ClaimTypes.NameIdentifier,checkUser.Id.ToString()),
                    new Claim(ClaimTypes.Role,"Admin")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                return RedirectToAction("Index", "About", new { area = "Admin" });
            }

            return View();


        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
