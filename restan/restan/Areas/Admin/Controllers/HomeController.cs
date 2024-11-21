﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using restan.Enums;

namespace restan.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(UserRole.Admin))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}