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
        [StringLength(50)]
        public string Area { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(100)]
        public string Setting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(2000)]
        public string DataValue { get; set; }


    }
}
