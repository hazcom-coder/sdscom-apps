using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using SDSComApps.Models;

namespace SDSComApps.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class DataSheetController : BaseController
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
        public DataSheetController(IConfiguration _config, IMemoryCache _cache, IHttpContextAccessor _httpContextAccessor) 
            : base(_config, _cache, _httpContextAccessor)
        {
            config = _config;
            cache = _cache;
            httpContextAccessor = _httpContextAccessor;
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
        public IActionResult InformationFromExportingSystem()
        {
            ViewData["productid"] = this.SessionEntityID;
            ViewData["username"] = this.SessionUserName;

            return View("~/Views/Author/Chapters/InformationFromExportingSystem.cshtml");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult SaveInformationFromExportingSystem([FromBody] InformationFromExportingSystem ifes)
        {
            return Ok(new { Success = true });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult IdentificationSubstPrep()
        {
            return View("~/Views/Author/Chapters/IdentificationSubstPrep.cshtml");
        }
    }
}