using System;
using NpgsqlTypes;
using ServiceStack.DataAnnotations;

namespace SchemaLoader.Models
{
    public class ValidationMessage
    {
        public ValidationMessage()
        {


        }


        [PrimaryKey]
        [AutoIncrement]
		public int ID { get; set; }

        [Required]
        public int FacetId {get; set;}

        [Required]
        private string Data {get; set;}

    }

}