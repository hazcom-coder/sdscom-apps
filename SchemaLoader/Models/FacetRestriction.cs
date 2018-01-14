using System;
using System.Collections.Generic;
using System.Text;
using NpgsqlTypes;
using ServiceStack.DataAnnotations;

namespace SchemaLoader.Models
{
	public class FacetRestriction
	{
		public FacetRestriction()
		{
			Enumerations = new List<string>();
		}

        [PrimaryKey]
        [AutoIncrement]
		public int ID { get; set; }

 		[StringLength(100)]
        [Required]
		public string Name {get; set;}

		[Required]
		public int FacetID { get; set; }

		[Required]
		public bool IsList { get; set; }

		public string RegularExpressionPattern { get; set; }

		public List<String> Enumerations { get; set; }

		public string OtherInfo{ get; set; }

}

}
