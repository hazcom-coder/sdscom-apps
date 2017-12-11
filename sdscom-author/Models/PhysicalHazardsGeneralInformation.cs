using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    public class PhysicalHazardsGeneralInformation
    {
        private Phrase justificationForDataWaivingField;

        private Phrase assessmentField;

        private Phrase classificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase JustificationForDataWaiving
        {
            get
            {
                return this.justificationForDataWaivingField;
            }
            set
            {
                this.justificationForDataWaivingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Assessment
        {
            get
            {
                return this.assessmentField;
            }
            set
            {
                this.assessmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }
    }
}
