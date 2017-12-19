using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using SDSComApps.Managers;
using Microsoft.Extensions.Configuration;

namespace SDSComApps.Controllers
{
    public class ProductController : Controller
    {
        private readonly IConfiguration config;

        public ProductController(IConfiguration _config)
        {
            this.config = _config;
        }

        public IActionResult Index()
        {
            DataManager dMgr = new DataManager(config);

            return View("Common/Product");
        }

        public IActionResult Phrase()
        {  
            return View("Common/Phrase");
        }

        public IActionResult Save()
        {
            int x = 0;            

            return Ok(new {Success = "true" , NewID = x});
        }
    }
}