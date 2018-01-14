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
        private List<Facet> facetLists = new List<Facet>();


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
        public List<Facet>  GetSchemas()
        {
            XmlTextReader textReader = new XmlTextReader(appdatafolder +"/SDSComXML.xsd");

			XmlDocument xdcc = new XmlDocument();

            xdcc.Load(textReader);

            XmlNode root = xdcc.DocumentElement;
            List<string> nodeNames = new List<string>();

            XmlNode datasheetNode;
            XmlNode chapterNode;

            foreach (XmlNode node in root.ChildNodes)
            {	
				nodeNames.Add(node.Name);

                if (node.Name == "xs:element")
                {
                    datasheetNode = node.ChildNodes[1].ChildNodes[0].ChildNodes[1];

					AddFacet(0, "", "DataSheet", "1", "1", "SDSComXML.xsd", "4.2.0","root",-1);

					for ( int x = 1; x <= datasheetNode.ChildNodes[1].ChildNodes[0].ChildNodes.Count - 1; x++ )
					{
						chapterNode = datasheetNode.ChildNodes[1].ChildNodes[0].ChildNodes[x];

						AddElementAsFacet(chapterNode, "datasheet");

						BuildChapter(chapterNode, "datasheet");
					}
					break;
                }
            }

			//update parent ids
			foreach (Facet facet in facetLists)
			{
				facetLists.Where(w => w.ParentPath == facet.Name).ToList()
					.ForEach(f => f.ParentID = facet.ID);
			}

			facetLists.Where(w => w.ParentID == 0).ToList().ForEach(f => f.ParentID = 1);

			return facetLists;
		}

		private string AddElementAsFacet(XmlNode theNode, string parentName)
		{
			string minOccurs = "0";
			string maxOccurs = "0";
			string facetName = string.Empty;
			string dataType = string.Empty;
			string retValue = parentName;
			int maxSize = -1;

			if (theNode.Attributes != null)
			{

				if (theNode.Attributes["name"] != null)
				{
					facetName = theNode.Attributes["name"].Value;
				}

				if (theNode.Attributes["minOccurs"] != null)
				{
					minOccurs = theNode.Attributes["minOccurs"].Value;
				}

				if (theNode.Attributes["maxOccurs"] != null)
				{
					maxOccurs = theNode.Attributes["maxOccurs"].Value;
				}

				if (theNode.Attributes["type"] != null)
				{
					string tmpType = theNode.Attributes["type"].Value;

					if (tmpType.StartsWith("xs:"))
					{
						tmpType = tmpType.Replace("xs:", string.Empty);
					}

					dataType = tmpType;

					if (dataType.ToLower().Contains("string"))
					{
						string tmpSize = dataType.Replace("string", string.Empty);
						bool ok = int.TryParse(tmpSize, out maxSize);						
					}

					if (dataType.ToLower().Contains("int"))
					{
						string tmpSize = dataType.Replace("int", string.Empty);
						bool ok = int.TryParse(tmpSize, out maxSize);
					}
				}

				AddFacet(0, parentName, facetName, minOccurs, maxOccurs, "SDSComXML.xsd", "4.2.0", dataType, maxSize);
				retValue = facetName;
			}

			return retValue;
		}
		
		private void BuildChapter(XmlNode chapterNode,string facetName)
        {
			XmlNode nextNode = RecurseChildNodes(chapterNode, facetName);			
		}

		private XmlNode RecurseChildNodes(XmlNode theNode, string parentName)
		{
			XmlNode node = null;

			if (theNode.Name == "xs:element")
			{
				if (theNode.Attributes["name"] != null)
				{
					parentName = theNode.Attributes["name"].Value;
				}
			}

			foreach (XmlNode childNode in theNode.ChildNodes)
			{
				if (childNode.Name == "xs:element")
				{
					AddElementAsFacet(childNode, parentName);					
				}

				RecurseChildNodes(childNode, parentName);
			}

			return node;
		}

        private void AddFacet(int parentid, string parentPath,
                            string facetName, string minOccurs, string maxOccurs, 
                            string fileName, string sdsversion, string dataType, int maxSize)
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
                SDSComVersion = sdsversion,
				DataType = dataType,
				MaxSize = maxSize
            };
			facetLists.Add(facet);
			facetid++;
        }


		public List<FacetRestriction> GetDataTypes(List<Facet> facetList)
		{
			List<FacetRestriction> restrictions = new List<FacetRestriction>();

			XmlTextReader textReader = new XmlTextReader(appdatafolder + "/SDSComXMLDT.xsd");

			XmlDocument xdcc = new XmlDocument();

			xdcc.Load(textReader);

			XmlNode root = xdcc.DocumentElement;
			List<string> nodeNames = new List<string>();

			foreach (XmlNode node in root.ChildNodes)
			{
				nodeNames.Add(node.Name);

				if (node.Attributes != null)
				{
					if (node.Attributes["name"] != null)
					{
						string enumName = node.Attributes["name"].Value;
						Facet facet = facetList.Where(c => c.DataType == enumName).FirstOrDefault();
						string facetDescription = string.Empty;

						if (node.ChildNodes[0] != null)
						{
							facetDescription = node.ChildNodes[0].InnerText;
						}						

						if (facet != null)
						{
							if (!enumName.StartsWith("string") && !enumName.StartsWith("int") && !(enumName == "Phrase"))
							{	
								FacetRestriction restr = new FacetRestriction
								{
									ID = 0, //will be done later
									FacetID = facet.ID
								};

								string facetName = facet.Name;
								string facetDataType = facet.DataType;

								restr.Name = facetDataType;

								if (node.ChildNodes[1].ChildNodes[0].Name == "xs:enumeration")
								{
									restr.IsList = true;

									foreach (XmlNode enumValueNode in node.ChildNodes[1].ChildNodes)
									{
										if (enumValueNode.Attributes != null)
										{
											string enumValue = enumValueNode.Attributes[0].Value;
											restr.Enumerations.Add(enumValue);
										}
									}
								}
								else if (node.ChildNodes[1].ChildNodes[0].Name == "xs:pattern")
								{
									restr.IsList = false;
									string patternValue = node.ChildNodes[1].ChildNodes[0].Attributes[0].Value;
									restr.RegularExpressionPattern = patternValue;
								}
								restrictions.Add(restr);
							}
						}
					}
				}			
			}
			return restrictions;
		}		
	}
}