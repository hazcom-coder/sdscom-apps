using System;
using System.Collections.Generic;
using System.Text;

namespace SchemaLoader.Models
{
	public class FacetRestriction
	{
		public FacetRestriction()
		{
			Enumerations = new List<string>();
		}


		public int ID { get; set; }

		public string Name {get; set;}

		public int FacetID { get; set; }

		public bool IsList { get; set; }

		public string RegularExpressionPattern { get; set; }

		public List<String> Enumerations { get; set; }

		public string OtherInfo{ get; set; }

}

}
