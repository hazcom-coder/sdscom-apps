using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDSComApp.Models
{
	public class DOMItem
	{
		public DOMItem() { }

		public string Name { get; set; }

		public string Type { get; set; }

		public string ID { get; set; }

		public string Value { get; set; }

		public decimal MinOccurs { get; set; }

		public decimal MaxOccurs { get; set; }

		public int Sequence { get; set; }

		public string ItemType { get; set; }

		public List<DOMItem> SubItems { get; set; }

		public DOMChoiceItem Choice { get; set; }
	}

	public class DOMChoiceItem
	{
		public DOMChoiceItem() { }

		public string First { get; set; }

		public List<DOMItem> FirstSubItems { get; set; }

		public string Second { get; set; }

		public List<DOMItem> SecondSubItems { get; set; }

	}
}