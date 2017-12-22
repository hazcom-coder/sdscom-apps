using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;

namespace SDSComApps.Controllers
{
    /// <summary>
    /// all controllers must inherit from this
    /// </summary>
    public class BaseController : Controller
    {
        private IHttpContextAccessor httpContextAccessor;
        private ISession Session => httpContextAccessor.HttpContext.Session;
        private IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>      
        public BaseController(IConfiguration _config, IMemoryCache _cache, IHttpContextAccessor _httpContextAccessor)
        {
            config = _config;
            cache = _cache;
            httpContextAccessor = _httpContextAccessor;                       
        }

        /// <summary>
        /// 
        /// </summary>
        public string SessionEntityID
        {
            get { return Session.GetString("entityid"); }
            set { Session.SetString("entityid", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SessionEntityName
        {
            get { return Session.GetString("entityname"); }
            set { Session.SetString("entityname", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SessionTemplate
        {
            get { return Session.GetString("template"); }
            set { Session.SetString("template", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SessionUserName
        {
            get { return Session.GetString("username"); }
            set { Session.SetString("username", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SessionUserID
        {
            get { return Session.GetString("userid"); }
            set { Session.SetString("userid", value); }
        }
    }
}
