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
using Microsoft.AspNetCore.Http;
using ServiceStack;


namespace SDSComApps.Controllers
{
    /// <summary>
    /// basic start page
    /// </summary>
    public class HomeController : BaseController
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private ISession Session => httpContextAccessor.HttpContext.Session;
        private readonly IConfiguration config;
        private IMemoryCache cache;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        /// <param name="_httpContextAccessor"></param>
        public HomeController(IConfiguration _config, IMemoryCache _cache, IHttpContextAccessor _httpContextAccessor)
            : base(_config, _cache, _httpContextAccessor)
        {
            this.config = _config;
            this.cache = _cache;
            this.httpContextAccessor = _httpContextAccessor;

            this.SessionEntityID = "1";
            this.SessionUserName = "tester";

        }

       
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
          //  DocumentManager dMgr = new DocumentManager(config);
           // dMgr.LoadSchemaStructure();

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
        public IActionResult AdminIndex()
        {
            return View("~/Views/Administrator/AdminIndex.cshtml");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult AuthorIndex()
        {
            return View("~/Views/Author/AuthorIndex.cshtml");
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
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
