using ECampus.Modele_de_vue_communes;
using Microsoft.AspNetCore.Mvc;

namespace ECampus.Controllers
{
    public class LoginController : Controller
    {
    
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }
    }
}