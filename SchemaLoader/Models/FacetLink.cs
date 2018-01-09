using System;

namespace SchemaLoader.Models
{
    public class FacetLink
    {
        public FacetLink()
        {

        }

        public int FacetId {get; set;}

        public int PhraseId {get; set;}

        public DateTime DateStamp {get; set;}

        public int UserId {get; set;}

    }

}