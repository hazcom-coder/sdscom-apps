using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using SDSComApps.Managers;
using SDSComApps.Models;

namespace SDSComApps.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Area("Administrator")]
    public class AdministratorController : BaseController
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
        public AdministratorController(IConfiguration _config, IMemoryCache _cache, IHttpContextAccessor _httpContextAccessor)
            : base(_config, _cache, _httpContextAccessor)
        {
            this.config = _config;
            this.cache = _cache;
            this.httpContextAccessor = _httpContextAccessor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View("~/Areas/Administrator/Views/AdminIndex.cshtml");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult ApplicationSettings()
        {
            return View("~/Areas/Administrator/Views/ApplicationSettings.cshtml");
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateDBObjects()
        {
            AdminManager aMgr = new AdminManager(config, cache);

            aMgr.CreateDBObjects();

            return Ok(new { Success = true });
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllApplicationSettings()
        {
            List<ApplicationSetting> allSettings = cache.Get<List<ApplicationSetting>>("APPLICATION_SETTINGS");

            return Ok(allSettings);
        }
    }
}