using System;

namespace SchemaLoader.Models
{
    public class FacetValue
    {
        public FacetValue()
        {

        }

        public int FaceteId {get; set;}

        public long EntityId {get; set;}

        public string Data {get; set;}

        public DateTime DateStamp {get; set;}

        public int UserId {get; set;}
        

    }
}