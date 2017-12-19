using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;

namespace SDSComApps.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Area("Author")]
    public class AuthorController : Controller
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public AuthorController(IConfiguration _config, IMemoryCache _cache)
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
            return View("~/Areas/Author/Views/Index.cshtml");
        }
    }
}