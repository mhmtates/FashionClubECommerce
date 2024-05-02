using Microsoft.AspNetCore.Mvc;

namespace FashionClubECommerce.WebUI.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
