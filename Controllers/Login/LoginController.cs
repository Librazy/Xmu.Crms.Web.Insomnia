using Microsoft.AspNetCore.Mvc;

namespace Xmu.Crms.Web.Insomnia.Controllers.Login
{
    [Route("")]
    public class LoginController : Controller
    {
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