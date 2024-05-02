using Microsoft.AspNetCore.Mvc;

namespace FashionClubECommerce.AdminUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
