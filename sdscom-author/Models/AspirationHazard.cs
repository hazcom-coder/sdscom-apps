using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class AspirationHazard
    {

        private AspirationHazardTestResults aspirationHazardTestResultsField;

        private UnitValue aspirationHazardHydrocarbonContentField;

        private Phrase[] aspirationHazardOtherInfoField;

        private Phrase[] aspirationHazardHumanExperienceField;

        private Phrase[] assessmentAspirationHazardClassificationField;

        private Phrase[] aspirationHazardCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AspirationHazardTestResults AspirationHazardTestResults
        {
            get
            {
                return this.aspirationHazardTestResultsField;
            }
            set
            {
                this.aspirationHazardTestResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue AspirationHazardHydrocarbonContent
        {
            get
            {
                return this.aspirationHazardHydrocarbonContentField;
            }
            set
            {
                this.aspirationHazardHydrocarbonContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AspirationHazardOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AspirationHazardOtherInfo
        {
            get
            {
                return this.aspirationHazardOtherInfoField;
            }
            set
            {
                this.aspirationHazardOtherInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AspirationHazardHumanExperience", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AspirationHazardHumanExperience
        {
            get
            {
                return this.aspirationHazardHumanExperienceField;
            }
            set
            {
                this.aspirationHazardHumanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssessmentAspirationHazardClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentAspirationHazardClassification
        {
            get
            {
                return this.assessmentAspirationHazardClassificationField;
            }
            set
            {
                this.assessmentAspirationHazardClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AspirationHazardComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AspirationHazardComments
        {
            get
            {
                return this.aspirationHazardCommentsField;
            }
            set
            {
                this.aspirationHazardCommentsField = value;
            }
        }
    }

}
