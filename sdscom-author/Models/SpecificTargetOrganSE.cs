using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class SpecificTargetOrganSE
    {
        private STOTData[] specificTargetOrganSETestResultsField;

        private SpecificTargetOrganSEOtherInfo[] specificTargetOrganSEOtherInfoField;

        private Phrase specificTargetOrganSEHumanExperienceField;

        private Phrase[] assessmentSpecificTargetOrganSEClassificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecificTargetOrganSETestResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public STOTData[] SpecificTargetOrganSETestResults
        {
            get
            {
                return this.specificTargetOrganSETestResultsField;
            }
            set
            {
                this.specificTargetOrganSETestResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecificTargetOrganSEOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SpecificTargetOrganSEOtherInfo[] SpecificTargetOrganSEOtherInfo
        {
            get
            {
                return this.specificTargetOrganSEOtherInfoField;
            }
            set
            {
                this.specificTargetOrganSEOtherInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase SpecificTargetOrganSEHumanExperience
        {
            get
            {
                return this.specificTargetOrganSEHumanExperienceField;
            }
            set
            {
                this.specificTargetOrganSEHumanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssessmentSpecificTargetOrganSEClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentSpecificTargetOrganSEClassification
        {
            get
            {
                return this.assessmentSpecificTargetOrganSEClassificationField;
            }
            set
            {
                this.assessmentSpecificTargetOrganSEClassificationField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class SpecificTargetOrganSEOtherInfo
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

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class SpecificTargetOrganRE
    {

        private STOTData[] specificTargetOrganRETestResultsField;

        private SpecificTargetOrganREOtherInfo[] specificTargetOrganREOtherInfoField;

        private Phrase specificTargetOrganREHumanExperienceField;

        private Phrase[] assessmentSpecificTargetOrganREClassificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecificTargetOrganRETestResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public STOTData[] SpecificTargetOrganRETestResults
        {
            get
            {
                return this.specificTargetOrganRETestResultsField;
            }
            set
            {
                this.specificTargetOrganRETestResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecificTargetOrganREOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SpecificTargetOrganREOtherInfo[] SpecificTargetOrganREOtherInfo
        {
            get
            {
                return this.specificTargetOrganREOtherInfoField;
            }
            set
            {
                this.specificTargetOrganREOtherInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase SpecificTargetOrganREHumanExperience
        {
            get
            {
                return this.specificTargetOrganREHumanExperienceField;
            }
            set
            {
                this.specificTargetOrganREHumanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssessmentSpecificTargetOrganREClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentSpecificTargetOrganREClassification
        {
            get
            {
                return this.assessmentSpecificTargetOrganREClassificationField;
            }
            set
            {
                this.assessmentSpecificTargetOrganREClassificationField = value;
            }
        }
    }
}
