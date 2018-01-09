using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchemaLoader.Models;
using System.Xml.Schema;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections;
using System.Data;


namespace SchemaLoader.Managers
{
    /// <summary>
    /// 
    /// </summary>
	public class DocumentManager
	{
        private string appdatafolder = @"schemas";
        private int facetid = 1;
        private List<Facet> attributes = new List<Facet>();


        /// <summary>
        /// 
        /// </summary>
        public DocumentManager()
        {
           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void GetSchemas()
        {

           // appdatafolder = @"\schemas";

            // XmlSchemaSet schemaSet = new XmlSchemaSet();
            // schemaSet.ValidationEventHandler += new ValidationEventHandler(ValidationCallback);           

            // DirectoryInfo d = new DirectoryInfo(appdatafolder);

            // foreach (var file in d.GetFiles("*.xsd"))
            // {
                XmlTextReader textReader = new XmlTextReader(appdatafolder +"/SDSComXML.xsd");

                XmlDocument xdcc = new XmlDocument();

                xdcc.Load(textReader);

                XmlNode root = xdcc.DocumentElement;
                List<string> nodeNames = new List<string>();

                XmlNode datasheetNode;
                XmlNode chapter0Node;


                foreach (XmlNode node in root.ChildNodes)
                {
                    nodeNames.Add(node.Name);

                    if (node.Name == "xs:element")
                    {
                        string t = node.InnerText;
                        datasheetNode = node.ChildNodes[1].ChildNodes[0].ChildNodes[1];
                        chapter0Node = datasheetNode.ChildNodes[1].ChildNodes[0].ChildNodes[1];






                        break;
                    }
                }

           //}

            //schemaSet.Compile();

           // return schemaSet;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool LoadSchemaStructure()
        {
            DirectoryInfo d = new DirectoryInfo(appdatafolder);
            XmlTextReader textReader = new XmlTextReader(appdatafolder + @"\SDSComXML.xsd");

            XmlDocument xdcc = new XmlDocument();

            xdcc.Load(textReader);

             //create the root facet - the dataSheet
            AddFacet(0,"","DataSheet",1,1,"SDSComXML.xsd","4.2.0");

            XmlNode root = xdcc.DocumentElement;

            XmlNode datasheetNode = null;
            XmlNode chapter0Node = null;

            foreach (XmlNode node in root.ChildNodes)
            {     
                if (node.Name == "xs:element")
                {
                    string t = node.InnerText;
                    datasheetNode = node.ChildNodes[1].ChildNodes[0].ChildNodes[1];
                    chapter0Node = datasheetNode.ChildNodes[1].ChildNodes[0].ChildNodes[1];
                    BuildChapter(chapter0Node);

                    break;
                }
            }

           

            


            BuildInformationFromExportingSystemPage(chapter0Node);

            //Datasheet sds = new Datasheet();
            //InformationFromExportingSystem chapter0 = new InformationFromExportingSystem();

            return true;

        }

        private void BuildInformationFromExportingSystemPage(XmlNode chapter0Node)
        {

        }

        private void BuildChapter(XmlNode chapterNode)
        {

        }

        private void AddFacet(int parentid, string parentPath,
                            string facetName, int minOccurs, int maxOccurs, 
                            string fileName, string sdsversion)
        {
            Facet facet = new Facet
            {
                DateStamp = DateTime.Now,
                ID = facetid,
                MaxOccurs = maxOccurs,
                MinOccurs = minOccurs,
                Name = facetName,
                ParentID = parentid,
                ParentPath = parentPath,
                SchemaFileName = fileName,
                SDSComVersion = sdsversion
            };

            facetid++;
        }


		private void ValidationCallback(object sender, ValidationEventArgs args)
		{
			if (args.Severity == XmlSeverityType.Warning)
				Console.Write("WARNING: ");
			else if (args.Severity == XmlSeverityType.Error)
				Console.Write("ERROR: ");

			Console.WriteLine(args.Message);
		}
		
	}
}