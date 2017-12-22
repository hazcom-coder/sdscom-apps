using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using SDSComApps.Managers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Http;
using SDSComApps.Models;

namespace SDSComApps.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Area("Author")]
    public class EntityController : BaseController
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
        public EntityController(IConfiguration _config, IMemoryCache _cache,IHttpContextAccessor _httpContextAccessor)
            : base(_config, _cache, _httpContextAccessor)
        {
            this.config = _config;
            this.cache = _cache;
            this.httpContextAccessor = _httpContextAccessor;
        }

        /// <summary>
        /// should not be called directly
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View("Error");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EditEntity()
        {            
            Entity entity = new Entity();
            EntityManager eMgr = new EntityManager(config, cache);

            long entityid = 0;
            long.TryParse(SessionEntityID, out entityid);

            if (entityid > 0)
            {
                entity = eMgr.Get(entityid);
            }                      
            
            return View("~/Areas/Author/Views/EditEntity.cshtml", entityid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult CreateDataSheet()
        {
            return View("~/Areas/Author/Views/DataSheet.cshtml");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Phrase()
        {  
            return View("Author/Phrase");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public IActionResult Save()
        {
                 

            return Ok();
        }
    }
}