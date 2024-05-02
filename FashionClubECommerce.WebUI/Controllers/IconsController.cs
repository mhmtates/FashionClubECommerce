using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FashionClubECommerce.WebUI.Controllers
{
    [AllowAnonymous]
    public class IconsController : Controller
    {
        [Route("/ikonlar")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
