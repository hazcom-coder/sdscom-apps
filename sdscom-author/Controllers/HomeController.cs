using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SDSComApps.Models;
using SDSComApps.Managers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;

namespace SDSComApps.Controllers
{
    /// <summary>
    /// basic start page
    /// </summary>
    public class HomeController : Controller
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public HomeController(IConfiguration _config, IMemoryCache _cache)
        {
            this.config = _config;
            this.cache = _cache;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View("AppMenu");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //public IActionResult Administrator()
        //{
        //    AdminManager adminMgr = new AdminManager(config, cache);

        //    adminMgr.MapElements();

        //    return View("~/Areas/Administrator/Views/Administrator.cshtml");
        //}

        //public IActionResult PhraseManager()
        //{
        //    AdminManager adminMgr = new AdminManager(config, cache);

        //    adminMgr.MapElements();

        //    return View("~/Areas/Author/Views/Phrase.cshtml");
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
