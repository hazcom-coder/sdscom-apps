using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class DpdDsdHazardClassificationMultiplyingFactor
    {

        private string factorValueField;

        private Phrase[] factorCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FactorValue
        {
            get
            {
                return this.factorValueField;
            }
            set
            {
                this.factorValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FactorComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] FactorComments
        {
            get
            {
                return this.factorCommentsField;
            }
            set
            {
                this.factorCommentsField = value;
            }
        }
    }

}
