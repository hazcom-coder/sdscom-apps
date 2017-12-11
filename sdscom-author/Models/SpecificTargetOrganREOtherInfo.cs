using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class AspirationHazardTestResults
    {

        private ToxicityTypeEnum toxicityTypeField;

        private Phrase testMethodField;

        private ExposureRouteEnum exposureRouteField;

        private UnitValue exposureTimeField;

        private UnitValue valueField;

        private Species speciesField;

        private Phrase testReferenceField;

        private Phrase[] commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ToxicityTypeEnum ToxicityType
        {
            get
            {
                return this.toxicityTypeField;
            }
            set
            {
                this.toxicityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase TestMethod
        {
            get
            {
                return this.testMethodField;
            }
            set
            {
                this.testMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureRouteEnum ExposureRoute
        {
            get
            {
                return this.exposureRouteField;
            }
            set
            {
                this.exposureRouteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue ExposureTime
        {
            get
            {
                return this.exposureTimeField;
            }
            set
            {
                this.exposureTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Species Species
        {
            get
            {
                return this.speciesField;
            }
            set
            {
                this.speciesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase TestReference
        {
            get
            {
                return this.testReferenceField;
            }
            set
            {
                this.testReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class SpecificTargetOrganREOtherInfo
    {
        private Phrase[] generalField;

        private Phrase[] inhalationField;

        private Phrase[] skinField;

        private Phrase[] eyeField;

        private Phrase[] ingestionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("General", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] General
        {
            get
            {
                return this.generalField;
            }
            set
            {
                this.generalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Inhalation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Inhalation
        {
            get
            {
                return this.inhalationField;
            }
            set
            {
                this.inhalationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Skin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Skin
        {
            get
            {
                return this.skinField;
            }
            set
            {
                this.skinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Eye", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Eye
        {
            get
            {
                return this.eyeField;
            }
            set
            {
                this.eyeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ingestion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Ingestion
        {
            get
            {
                return this.ingestionField;
            }
            set
            {
                this.ingestionField = value;
            }
        }
    }
}
