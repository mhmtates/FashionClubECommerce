using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FashionClubECommerce.WebUI.Controllers
{
     [AllowAnonymous]
    public class TypographyController : Controller
    {
        [Route("/tipografi")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
