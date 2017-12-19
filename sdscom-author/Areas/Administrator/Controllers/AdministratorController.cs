using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using SDSComApps.Managers;
using Newtonsoft;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace SDSComApps.Areas.Administrator.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Area("Administrator")]
    public class AdministratorController : Controller
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public AdministratorController(IConfiguration _config, IMemoryCache _cache)
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
            return View("~/Areas/Administrator/Views/Index.cshtml");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ClearCache()
        {
            DataManager dMgr = new DataManager(config, cache);
            dMgr.ClearCache();
            return Ok(new {success = true });
        }
    }
}