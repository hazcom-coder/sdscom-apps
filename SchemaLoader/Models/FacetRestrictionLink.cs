using System;
using NpgsqlTypes;
using ServiceStack.DataAnnotations;

namespace SchemaLoader.Models
{
    public class FacetRestrictionLink
    {
        public FacetRestrictionLink()
        {

        }


        [PrimaryKey]
        [AutoIncrement]
        public int ID {get; set;}

        [Required]
        public int FacetId {get; set;}

        [Required]
        public int PhraseId {get; set;}

        [Required]
        public DateTime DateStamp {get; set;}

        [Required]
        public int UserId {get; set;}

    }

}