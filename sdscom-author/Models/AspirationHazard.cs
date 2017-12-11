using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class AspirationHazard
    {
        private AspirationHazardTestResults aspirationHazardTestResultsField;

        private UnitValue aspirationHazardHydrocarbonContentField;

        private Phrase[] aspirationHazardOtherInfoField;

        private Phrase[] aspirationHazardHumanExperienceField;

        private Phrase[] assessmentAspirationHazardClassificationField;

        private Phrase[] aspirationHazardCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElement("AspirationHazardOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElement("AspirationHazardHumanExperience", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElement("AssessmentAspirationHazardClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElement("AspirationHazardComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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

        public AspirationHazardTestResults AspirationHazardTestResultsField { get => aspirationHazardTestResultsField; set => aspirationHazardTestResultsField = value; }
        public UnitValue AspirationHazardHydrocarbonContentField { get => aspirationHazardHydrocarbonContentField; set => aspirationHazardHydrocarbonContentField = value; }
        public Phrase[] AspirationHazardOtherInfoField { get => aspirationHazardOtherInfoField; set => aspirationHazardOtherInfoField = value; }
        public Phrase[] AspirationHazardHumanExperienceField { get => aspirationHazardHumanExperienceField; set => aspirationHazardHumanExperienceField = value; }
        public Phrase[] AssessmentAspirationHazardClassificationField { get => assessmentAspirationHazardClassificationField; set => assessmentAspirationHazardClassificationField = value; }
        public Phrase[] AspirationHazardCommentsField { get => aspirationHazardCommentsField; set => aspirationHazardCommentsField = value; }
    }

}
