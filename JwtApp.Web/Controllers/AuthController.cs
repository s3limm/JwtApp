using Microsoft.AspNetCore.Mvc;

namespace JwtApp.Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
