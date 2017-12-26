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
    public class AuthorController : BaseController
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
        public AuthorController(IConfiguration _config, IMemoryCache _cache, IHttpContextAccessor _httpContextAccessor)
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
            return View("AuthorIndex");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
            return View("EditEntity");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult CreateDataSheet()
        {
            return View("DataSheet");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult GetPhrases(string start, string length)
        {
            PhraseManager pMgr = new PhraseManager(config, cache);

            List<EuphracPhrase> phrases = pMgr.Get();

            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            var data = phrases.Skip(skip).Take(pageSize).ToList();

            return Json(data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult PhraseList()
        {
            return View("PhraseList");
        }

       

    }

}