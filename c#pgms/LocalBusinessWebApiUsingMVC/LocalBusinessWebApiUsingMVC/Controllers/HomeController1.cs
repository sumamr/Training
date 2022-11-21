using Microsoft.AspNetCore.Mvc;

namespace LocalBusinessWebApiUsingMVC.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
