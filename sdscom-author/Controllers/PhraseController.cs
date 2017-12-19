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

namespace SDSComApps.Controllers
{
    public class PhraseController : Controller
    {

       
        private readonly IConfiguration config;

        public PhraseController(IConfiguration _config)
        {
            this.config = _config;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get(string start, string length)
        {
            PhraseManager pMgr = new PhraseManager(config);

            List<EuphracPhrase> phrases = pMgr.Get();
            
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            var data = phrases.Skip(skip).Take(pageSize).ToList();

            return Ok(data);
        }
    }

   
}