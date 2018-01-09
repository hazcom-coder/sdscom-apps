using System;

namespace SchemaLoader.Models
{
    public class Facet
    {
        public Facet()
        {            

        }

        public string ParentPath {get; set;}

        public int ParentID{get; set;}

        public string Name {get; set;}

        public int ID {get; set;}

        public int MinOccurs {get; set;}

        public int MaxOccurs {get; set;}

        public int DataType {get; set;}

        public DateTime DateStamp {get; set;}

        public string SDSComVersion {get; set;}

        public string SchemaFileName {get; set;}

    }
}