using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SDSComApps.Models;
using System.Xml.Schema;
using System.Reflection;
using Npgsql.PostgresTypes;
using Npgsql;
using System.Collections;

namespace SDSComApps.Managers
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

            XmlSchema sdsSchema = null;
            foreach (XmlSchema schema in schemaSet.Schemas())
            {
                sdsSchema = schema;
            }

        //Datasheet theSheet = new Datasheet();

        //    PrintAllTypes(typeof(Datasheet), "");

            return true;
        }


        private void RecurseElements(XmlSchema sdsSchema, XmlSchemaElement element2)
        {
            foreach (XmlSchemaElement element in sdsSchema.Elements.Values)
            {
                Console.WriteLine("Element: {0}", element.Name);

                XmlSchemaComplexType complexType = element.ElementSchemaType as XmlSchemaComplexType;

                if (complexType.AttributeUses.Count > 0)
                {
                    IDictionaryEnumerator enumerator = complexType.AttributeUses.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        XmlSchemaAttribute attribute = (XmlSchemaAttribute)enumerator.Value;

                        Console.WriteLine("Attribute: {0}", attribute.Name);
                    }
                }

                XmlSchemaSequence sequence = complexType.ContentTypeParticle as XmlSchemaSequence;

                foreach (XmlSchemaElement childElement in sequence.Items)
                {
                    Console.WriteLine("Element: {0} {1} {2} {3}", childElement.Name, childElement.Parent.ToString(), childElement.MinOccurs, childElement.MaxOccurs);
                    
                }
            }
        }


        private List<Type> alreadyVisitedTypes = new List<Type>(); // to avoid infinite recursion

        public void PrintAllTypes(Type currentType, string prefix)
        {
            //if (alreadyVisitedTypes.Contains(currentType)) return;
            //alreadyVisitedTypes.Add(currentType);
            //foreach (PropertyInfo pi in currentType.GetProperties())
            //{
            //    NpgsqlCommand cmd = new NpgsqlCommand();
            //    cmd.CommandText = @"INSERT INTO ATTRIBUTES (
            //                        ATTRIBUTE_NAME, ATTRIBUTE_TYPE, DATE_STAMP, USER_ID, MINOCCURS,MAXOCCURS)
            //                        VALUES ('" + pi.Name + "','" + pi.PropertyType.Name + "', now(),1,'0','0')  ";
            //    dataMgr.Execute(cmd);
            //   // Console.WriteLine($"{prefix} {pi.PropertyType.Name} {pi.Name}");
            //    if (!pi.PropertyType.IsPrimitive) PrintAllTypes(pi.PropertyType, prefix + "  ");
            //}


        }
    }
}
