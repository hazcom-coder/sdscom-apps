using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ReproductiveToxicity
    {
        private CMRData[] reproductiveToxicityTestResultsField;

        private Phrase[] reproductiveToxicityOtherInfoField;

        private Phrase[] reproductiveToxicityHumanExperienceField;

        private Phrase[] assessmentReproductiveToxicityClassificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReproductiveToxicityTestResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CMRData[] ReproductiveToxicityTestResults
        {
            get
            {
                return this.reproductiveToxicityTestResultsField;
            }
            set
            {
                this.reproductiveToxicityTestResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReproductiveToxicityOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ReproductiveToxicityOtherInfo
        {
            get
            {
                return this.reproductiveToxicityOtherInfoField;
            }
            set
            {
                this.reproductiveToxicityOtherInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReproductiveToxicityHumanExperience", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ReproductiveToxicityHumanExperience
        {
            get
            {
                return this.reproductiveToxicityHumanExperienceField;
            }
            set
            {
                this.reproductiveToxicityHumanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssessmentReproductiveToxicityClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentReproductiveToxicityClassification
        {
            get
            {
                return this.assessmentReproductiveToxicityClassificationField;
            }
            set
            {
                this.assessmentReproductiveToxicityClassificationField = value;
            }
        }
    }
}
