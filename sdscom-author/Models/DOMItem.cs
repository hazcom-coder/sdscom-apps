using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDSComApps.Models
{
    /// <remarks/>
	public class DOMItem
	{
        /// <remarks/>
		public DOMItem() { }

        /// <remarks/>
		public string Name { get; set; }

        /// <remarks/>
		public string Type { get; set; }

        /// <remarks/>
		public string ID { get; set; }

        /// <remarks/>
		public string Value { get; set; }

        /// <remarks/>
		public decimal MinOccurs { get; set; }

        /// <remarks/>
		public decimal MaxOccurs { get; set; }

        /// <remarks/>
		public int Sequence { get; set; }

        /// <remarks/>
		public string ItemType { get; set; }

        /// <remarks/>
		public List<DOMItem> SubItems { get; set; }

        /// <remarks/>
		public DOMChoiceItem Choice { get; set; }
	}

    /// <remarks/>
	public class DOMChoiceItem
	{
        /// <remarks/>
		public DOMChoiceItem() { }

        /// <remarks/>
		public string First { get; set; }

        /// <remarks/>
		public List<DOMItem> FirstSubItems { get; set; }

        /// <remarks/>
		public string Second { get; set; }

        /// <remarks/>
		public List<DOMItem> SecondSubItems { get; set; }

	}
}