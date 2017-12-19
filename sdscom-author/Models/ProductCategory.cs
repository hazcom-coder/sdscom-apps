using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApps.Models
{
    public class ProductCategory
    {

        private ProductCategoryCodeEnum pcCodeField;

        private Phrase pcFulltextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProductCategoryCodeEnum PcCode
        {
            get
            {
                return this.pcCodeField;
            }
            set
            {
                this.pcCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase PcFulltext
        {
            get
            {
                return this.pcFulltextField;
            }
            set
            {
                this.pcFulltextField = value;
            }
        }
    }

}
