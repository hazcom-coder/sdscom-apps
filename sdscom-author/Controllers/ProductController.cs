using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace SDSComApps.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("Common/Product");
        }

        public IActionResult Save()
        {
            int x = 0;            

            return Ok(new {Success = "true" , NewID = x});
        }
    }
}