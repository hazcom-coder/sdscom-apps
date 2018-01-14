using System;
using System.Collections.Generic;

namespace SchemaLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling GetSchemas");

            SchemaLoader.Managers.DocumentManager dMgr = new SchemaLoader.Managers.DocumentManager();

           List<Models.Facet> facets = dMgr.GetSchemas();

            Console.WriteLine("Finished GetSchemas");

			Console.WriteLine("Calling GetDataTypes");

			dMgr.GetDataTypes(facets);

			Console.WriteLine("Finished GetDataTypes function");

		}
    }
}
