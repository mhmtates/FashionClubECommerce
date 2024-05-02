using FashionClubECommerce.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FashionClubECommerce.WebUI.Controllers
{
    [AllowAnonymous]
    public class KampanyalarController : Controller
    {
        private readonly IProductsService products;
        
        public KampanyalarController(IProductsService _products)
        {
            products = _products;
           
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
