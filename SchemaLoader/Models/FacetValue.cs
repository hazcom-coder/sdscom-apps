using System;
using NpgsqlTypes;
using ServiceStack.DataAnnotations;


namespace SchemaLoader.Models
{
    public class FacetValue
    {
        public FacetValue()
        {

        }

        [PrimaryKey]
        [AutoIncrement]
		public int ID { get; set; }

        [Required]
        public int FaceteId {get; set;}

        [Required]
        public long EntityId {get; set;}

        [Required]
        public string Data {get; set;}

        [Required]
        public DateTime DateStamp {get; set;}

        [Required]
        public int UserId {get; set;}
        

    }
}