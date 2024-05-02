using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FashionClubECommerce.WebUI.Controllers
{

    public class AboutController : Controller
    {   
        [AllowAnonymous]
        [Route("/hakkimizda")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
