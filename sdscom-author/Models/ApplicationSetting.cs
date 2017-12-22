using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SDSComApps.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [AutoIncrement]
        [PrimaryKey]
        public long ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Setting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DataValue { get; set; }


    }
}
