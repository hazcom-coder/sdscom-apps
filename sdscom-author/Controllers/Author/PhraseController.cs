using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft;
using SDSComApps.Managers;
using SDSComApps.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Http;

namespace SDSComApps.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Area("Author")]
    public class PhraseController : BaseController
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
        public PhraseController(IConfiguration _config, IMemoryCache _cache, IHttpContextAccessor _httpContextAccessor)
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
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get(string start, string length)
        {
            PhraseManager pMgr = new PhraseManager(config, cache);

            List<EuphracPhrase> phrases = pMgr.Get();
            
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            var data = phrases.Skip(skip).Take(pageSize).ToList();

            return Ok(data);
        }
    }

   
}