using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    /// <remarks/>
    public class PhraseCatalogue
    {
        private string phraseCatalogueNameField;

        private string phraseCatalogueIssuerField;

        private string phraseCatalogueVersionField;

        private System.DateTime phraseCatalogueDateField;

        private string phraseCatalogueIdField;

        public PhraseCatalogue()
        {
            this.phraseCatalogueIdField = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PhraseCatalogueName
        {
            get
            {
                return this.phraseCatalogueNameField;
            }
            set
            {
                this.phraseCatalogueNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PhraseCatalogueIssuer
        {
            get
            {
                return this.phraseCatalogueIssuerField;
            }
            set
            {
                this.phraseCatalogueIssuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PhraseCatalogueVersion
        {
            get
            {
                return this.phraseCatalogueVersionField;
            }
            set
            {
                this.phraseCatalogueVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime PhraseCatalogueDate
        {
            get
            {
                return this.phraseCatalogueDateField;
            }
            set
            {
                this.phraseCatalogueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string PhraseCatalogueId
        {
            get
            {
                return this.phraseCatalogueIdField;
            }
            set
            {
                this.phraseCatalogueIdField = value;
            }
        }
    }

}
