using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Web.Group1.Controllers.Login
{
    [Route("")]
    public class LoginController : Controller
    {
        [Route("/")]
        public IActionResult HomePage()
        {
            return Redirect("/Login");
        }

        [Route("/Login")]
        public IActionResult AccountLoginPage()
        {
            return View();
        }

        [Route("/RegisterPage")]
        public IActionResult RegisterPage()
        {
            return View();
        }
    }
}