using System;
using System.Collections.Generic;
using SchemaLoader.Models;
using SchemaLoader.Managers;

namespace SchemaLoader
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Facet> facets = new List<Facet>();
			List<Facet> facetsDE = new List<Facet>();
			List<FacetRestriction> facetsRest = new List<FacetRestriction>();
			List<FacetRestriction> facetsRestDE = new List<FacetRestriction>();

			DocumentManager dMgr = new DocumentManager();

			//=========================================================================================================

			Console.WriteLine("Calling GetSchemas & DataTypes");

			facets = dMgr.GetSchemas();

			facetsRest = dMgr.GetDataTypes(facets, "SDSComXMLDT.xsd");

			Console.WriteLine("Finished GetSchemas & DataTypes");

			//=========================================================================================================

			Console.WriteLine("Start GetExtensions & DataTypes");

			facetsDE = dMgr.GetExtensions();

			facetsRestDE = dMgr.GetDataTypes(facetsDE, "SDSComXMLNE_DE.xsd");

			Console.WriteLine("Finished GetExtensions & DataTypes");

			//=========================================================================================================




		}
	}
}
