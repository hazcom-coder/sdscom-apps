using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class RespiratoryOrSkinSensitisation
    {

        private RespiratoryOrSkinSensitisationTestResults[] respiratoryOrSkinSensitisationTestResultsField;

        private RespiratoryOrSkinSensitisationOtherInformation respiratoryOrSkinSensitisationOtherInformationField;

        private HumanExperience humanExperienceField;

        private ClassificationAssessment classificationAssessmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RespiratoryOrSkinSensitisationTestResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RespiratoryOrSkinSensitisationTestResults[] RespiratoryOrSkinSensitisationTestResults
        {
            get
            {
                return this.respiratoryOrSkinSensitisationTestResultsField;
            }
            set
            {
                this.respiratoryOrSkinSensitisationTestResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RespiratoryOrSkinSensitisationOtherInformation RespiratoryOrSkinSensitisationOtherInformation
        {
            get
            {
                return this.respiratoryOrSkinSensitisationOtherInformationField;
            }
            set
            {
                this.respiratoryOrSkinSensitisationOtherInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HumanExperience HumanExperience
        {
            get
            {
                return this.humanExperienceField;
            }
            set
            {
                this.humanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClassificationAssessment ClassificationAssessment
        {
            get
            {
                return this.classificationAssessmentField;
            }
            set
            {
                this.classificationAssessmentField = value;
            }
        }
    }

}
