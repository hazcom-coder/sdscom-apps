using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SDSComApps.Models;
using SDSComApps.Managers;
using Microsoft.Extensions.Configuration;

namespace SDSComApps.Controllers
{
    /// <summary>
    /// basic start page
    /// </summary>
    public class HomeController : Controller
    {
        private readonly IConfiguration config;

        public HomeController(IConfiguration _config)
        {
            this.config = _config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("AppMenu");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Administrator()
        {
            AdminManager adminMgr = new AdminManager(config);

            adminMgr.MapElements();

            return View();
        }

        public IActionResult PhraseManager()
        {
            AdminManager adminMgr = new AdminManager(config);

            adminMgr.MapElements();

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
