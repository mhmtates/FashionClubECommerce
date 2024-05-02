﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionClubECommerce.AdminUI.Controllers
{
    public class LogoutController : Controller
    { 
       [Route("Cikis")]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
