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
    public class AdministratorController : BaseController
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private ISession Session => httpContextAccessor.HttpContext.Session;
        private readonly IConfiguration config;
        private IMemoryCache cache;
        private UserManager uMgr;
        private ApplicationSettingsManager asMgr;

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
            uMgr = new UserManager(config, cache);
            asMgr = new ApplicationSettingsManager(config, cache);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View("AdminIndex");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult ApplicationSettings()
        {
            return View("ApplicationSettings");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult UserList()
        {
            return View("UserList");
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
        public JsonResult GetAllApplicationSettings()
        {
            List<ApplicationSetting> allSettings = asMgr.GetAll();

            return Json(allSettings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult GetUserList()
        {
            List<User> userList = uMgr.GetList();
            return Json(userList);
        }
    }
}