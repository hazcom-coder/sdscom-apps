using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDSComApps.Models
{
    /// <summary>
    /// 
    /// </summary>
	public class BaseDocumentItem
	{
        /// <summary>
        /// 
        /// </summary>
		public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
		public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
		public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
		public string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
		public decimal MinOccurs { get; set; }

        /// <summary>
        /// 
        /// </summary>
		public decimal MaxOccurs { get; set; }

        /// <summary>
        /// 
        /// </summary>
		public int Sequence { get; set; }
	}
}