using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDSComApps.Models
{
	public class BaseDocumentItem
	{
		public string Name { get; set; }

		public string Type { get; set; }

		public string ID { get; set; }

		public string Value { get; set; }

		public decimal MinOccurs { get; set; }

		public decimal MaxOccurs { get; set; }

		public int Sequence { get; set; }
	}
}