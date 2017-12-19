using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SDSComApps.Models;
using System.Xml.Schema;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace SDSComApps.Managers
{
	public class DocumentManager
	{
        private readonly IConfiguration config;
        private string appdatafolder;

        public DocumentManager(IConfiguration _config)
        {
            this.config = _config;

            appdatafolder = config["Folders:Schemas"];
        }

        public XmlSchemaSet GetSchemas()
        {
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.ValidationEventHandler += new ValidationEventHandler(ValidationCallback);
            //schemaSet.Add("http://www.tempuri.org", appdatafolder + @"\SDSComXML.xsd");
            //schemaSet.Add("http://www.tempuri.org", appdatafolder + @"\SDSComXMLCT.xsd");
            //schemaSet.Add("http://www.tempuri.org", appdatafolder + @"\SDSComXMLDT.xsd");
            //schemaSet.Add("http://www.tempuri.org", appdatafolder + @"\SDSComXMLNE_AD.xsd");
            

            DirectoryInfo d = new DirectoryInfo(appdatafolder);

            foreach (var file in d.GetFiles("*.xsd"))
            {
                schemaSet.Add("http://www.tempuri.org", appdatafolder + @"\" + file.Name);
            }

            schemaSet.Compile();

            return schemaSet;
        }

        public Document LoadDocumentSchema()
		{	
			Document doc = new Document();
			int chapterSequence = 1;
			int chapterItemSequence = 1;
			try
			{
				doc.Chapters = new List<Chapter>();
         
				XmlSchemaSet schemaSet = new XmlSchemaSet();
				schemaSet.ValidationEventHandler += new ValidationEventHandler(ValidationCallback);
				schemaSet.Add("http://www.tempuri.org", appdatafolder + @"\SDSComXML.xsd");
				schemaSet.Add("http://www.tempuri.org", appdatafolder + @"\SDSComXMLCT.xsd");
				schemaSet.Add("http://www.tempuri.org", appdatafolder + @"\SDSComXMLDT.xsd");
				schemaSet.Compile();

				foreach (XmlSchema schema in schemaSet.Schemas())
				{
					foreach (XmlSchemaElement element in schema.Elements.Values)
					{
						XmlSchemaSequence topSequence = GetSequence(element); 
						foreach (XmlSchemaElement childElement in topSequence.Items)
						{
							XmlSchemaSequence childSequence = GetSequence(childElement);
							foreach (XmlSchemaElement chapterElem in childSequence.Items)
							{
								string tmp = chapterElem.Name;

								Chapter sec = new Chapter()
								{
									Name = chapterElem.Name,
									MinOccurs = chapterElem.MinOccurs,
									MaxOccurs = chapterElem.MaxOccurs,
									Sequence = chapterSequence
								};
								chapterSequence++;

								XmlSchemaSequence childSequence2 = GetSequence(chapterElem); 
								sec.ChapterMembers = new List<ChapterMember>();
								foreach (var objItem in childSequence2.Items)
								{
									if (objItem is XmlSchemaElement)
									{ 
										XmlSchemaElement chapterItem = objItem as XmlSchemaElement;

										ChapterMember secItem = new ChapterMember()
										{
											Name = chapterItem.Name,
											MinOccurs = chapterItem.MinOccurs,
											MaxOccurs = chapterItem.MaxOccurs,
											Sequence = chapterItemSequence
										};
										chapterItemSequence++;

										XmlSchemaSequence childSequence3 = GetSequence(chapterItem); 
										if (childSequence3 != null)
										{
											secItem.ChapterMemberItems = new List<ChapterMemberItem>();
											foreach (XmlSchemaElement sequence3Item in childSequence3.Items)
											{												
												ChapterMemberItem chapterSubItem = new ChapterMemberItem()
												{
													Name = sequence3Item.Name,
													MinOccurs = sequence3Item.MinOccurs,
													MaxOccurs = sequence3Item.MaxOccurs,
													Type = sequence3Item.SchemaTypeName.ToString().Replace("http://www.w3.org/2001/XMLSchema:", string.Empty).Replace("http://www.tempuri.org:", string.Empty)
												};

												XmlSchemaSequence childSequence4 = GetSequence(sequence3Item);
												if (childSequence4 != null)
												{
													chapterSubItem.ChapterMemberItemDetails = new List<ChapterMemberItemDetail>();
													foreach (XmlSchemaElement sequence4Item in childSequence4.Items)
													{
														ChapterMemberItemDetail chapterMemberItemDetail = new ChapterMemberItemDetail()
														{
															Name = sequence4Item.Name,
															MinOccurs = sequence4Item.MinOccurs,
															MaxOccurs = sequence4Item.MaxOccurs,
															Type = sequence4Item.SchemaTypeName.ToString().Replace("http://www.w3.org/2001/XMLSchema:", string.Empty).Replace("http://www.tempuri.org:", string.Empty)
														};

														XmlSchemaSequence childSequence5 = GetSequence(sequence4Item);
														chapterMemberItemDetail.ChapterMemberItemDetailProperties = new List<ChapterMemberItemDetailProperty>();
														foreach (XmlSchemaElement sequence5Item in childSequence5.Items)
														{
															ChapterMemberItemDetailProperty chapterMemberItemDetailProperty = new ChapterMemberItemDetailProperty()
															{
																Name = sequence5Item.Name,
																MinOccurs = sequence5Item.MinOccurs,
																MaxOccurs = sequence5Item.MaxOccurs,
																Type = sequence5Item.SchemaTypeName.ToString().Replace("http://www.w3.org/2001/XMLSchema:", string.Empty).Replace("http://www.tempuri.org:", string.Empty)
															};

															chapterMemberItemDetail.ChapterMemberItemDetailProperties.Add(chapterMemberItemDetailProperty);
														}

														chapterSubItem.ChapterMemberItemDetails.Add(chapterMemberItemDetail);
													}
												}
												secItem.ChapterMemberItems.Add(chapterSubItem);
											}
										}

										sec.ChapterMembers.Add(secItem);
									
									}
									else if (objItem is XmlSchemaChoice)
									{
										ChapterMember secItem = new ChapterMember();
										XmlSchemaChoice choiceItem = objItem as XmlSchemaChoice;
										chapterItemSequence++;
										ChoiceItem choice = new ChoiceItem()
										{
											First = "One",
											Second = "Two"
										};
										chapterItemSequence++;
										secItem.ChoiceElement = choice;
										sec.ChapterMembers.Add(secItem);
									}									
								}

								doc.Chapters.Add(sec);
							}
						}
					}
				}

				//doc.Name = "Test Doc";
			}
			catch(Exception ex)
			{
				Console.Write(ex.Message);
			}

			return doc;
		}



		private XmlSchemaSequence GetSequence(XmlSchemaElement element)
		{
			if (element.ElementSchemaType is XmlSchemaComplexType)
			{
				XmlSchemaComplexType complexType = element.ElementSchemaType as XmlSchemaComplexType;
				return complexType.ContentTypeParticle as XmlSchemaSequence;
			}
			else
			{
				return new XmlSchemaSequence();
			}
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