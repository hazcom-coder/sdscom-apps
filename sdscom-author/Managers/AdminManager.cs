using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SDSComApp.Models;
using System.Xml.Schema;
using System.Reflection;
using Npgsql.PostgresTypes;
using Npgsql;


namespace SDSComApp.Managers
{
    public class AdminManager
    {
        private readonly IConfiguration config;

        private DataManager dataMgr;
        private DocumentManager docMgr;

        public AdminManager(IConfiguration _config)
        {
            this.config = _config;

            dataMgr = new DataManager(config);
            docMgr = new DocumentManager(config);
        }

        public bool MapElements()
        {
            XmlSchemaSet schemaSet = docMgr.GetSchemas();

            Datasheet theSheet = new Datasheet();

            PrintAllTypes(typeof(Datasheet), "");

            return true;
        }

        private List<Type> alreadyVisitedTypes = new List<Type>(); // to avoid infinite recursion

        public void PrintAllTypes(Type currentType, string prefix)
        {
            if (alreadyVisitedTypes.Contains(currentType)) return;
            alreadyVisitedTypes.Add(currentType);
            foreach (PropertyInfo pi in currentType.GetProperties())
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = @"INSERT INTO ATTRIBUTES (
                                    ATTRIBUTE_NAME, ATTRIBUTE_TYPE, DATE_STAMP, USER_ID, MINOCCURS,MAXOCCURS)
                                    VALUES ('" + pi.Name + "','" + pi.PropertyType.Name + "', now(),1,'0','0')  ";
                dataMgr.Execute(cmd);
               // Console.WriteLine($"{prefix} {pi.PropertyType.Name} {pi.Name}");
                if (!pi.PropertyType.IsPrimitive) PrintAllTypes(pi.PropertyType, prefix + "  ");
            }
        }
    }
}
