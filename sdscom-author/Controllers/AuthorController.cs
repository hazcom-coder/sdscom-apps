﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SDSComApps.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View("AuthorStart");
        }
    }
}