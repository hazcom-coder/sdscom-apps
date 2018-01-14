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

        public string MinOccurs {get; set;}

        public string MaxOccurs {get; set;}

        public string DataType {get; set;}

        public DateTime DateStamp {get; set;}

        public string SDSComVersion {get; set;}

        public string SchemaFileName {get; set;}

		public string Comments { get; set; }

		public int MaxSize { get; set; }

		public string OtherInfo { get; set; }

	}
}