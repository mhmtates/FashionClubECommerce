﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace FashionClubECommerce.WebUI.Controllers
{
    public class ContactController : Controller
    {
        [AllowAnonymous]
        [Route("/iletisim")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
