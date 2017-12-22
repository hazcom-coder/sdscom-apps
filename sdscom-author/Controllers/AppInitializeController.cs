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
    public interface IAppInitializeController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        void Initialize();

    }

    /// <summary>
    /// 
    /// </summary>
    public class AppInitializeController : IAppInitializeController
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public AppInitializeController(IConfiguration _config, IMemoryCache _cache)
        {
            config = _config;
            cache = _cache;

            Initialize();
        }

        /// <summary>
        /// set up application data in cache as needed
        /// </summary>
        /// <returns></returns>
        public void Initialize()
        {
            ApplicationSettingsManager asMgr = new ApplicationSettingsManager(config, cache);
            asMgr.LoadAllToCache();

            //-------------------------------------------------------------------------------------------------
            

            //-------------------------------------------------------------------------------------------------

        }
    }
}