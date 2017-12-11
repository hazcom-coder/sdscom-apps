using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class HumanExperience
    {

        private Phrase[] respiratorySensitisationHumanExperienceField;

        private Phrase[] skinSensitisationHumanExperienceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RespiratorySensitisationHumanExperience", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] RespiratorySensitisationHumanExperience
        {
            get
            {
                return this.respiratorySensitisationHumanExperienceField;
            }
            set
            {
                this.respiratorySensitisationHumanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SkinSensitisationHumanExperience", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SkinSensitisationHumanExperience
        {
            get
            {
                return this.skinSensitisationHumanExperienceField;
            }
            set
            {
                this.skinSensitisationHumanExperienceField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ClassificationAssessment
    {

        private Phrase[] assessmentRespiratorySensitisationClassificationField;

        private Phrase[] assessmentSkinSensitisationClassificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssessmentRespiratorySensitisationClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentRespiratorySensitisationClassification
        {
            get
            {
                return this.assessmentRespiratorySensitisationClassificationField;
            }
            set
            {
                this.assessmentRespiratorySensitisationClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssessmentSkinSensitisationClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentSkinSensitisationClassification
        {
            get
            {
                return this.assessmentSkinSensitisationClassificationField;
            }
            set
            {
                this.assessmentSkinSensitisationClassificationField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class RespiratoryOrSkinSensitisationOtherInformation
    {
        private Phrase[] respiratoryOrSkinSensitisationGeneralField;

        private Phrase[] respiratorySensitisationOtherInfoField;

        private Phrase[] skinSensitisationOtherInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RespiratoryOrSkinSensitisationGeneral", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] RespiratoryOrSkinSensitisationGeneral
        {
            get
            {
                return this.respiratoryOrSkinSensitisationGeneralField;
            }
            set
            {
                this.respiratoryOrSkinSensitisationGeneralField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RespiratorySensitisationOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] RespiratorySensitisationOtherInfo
        {
            get
            {
                return this.respiratorySensitisationOtherInfoField;
            }
            set
            {
                this.respiratorySensitisationOtherInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SkinSensitisationOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SkinSensitisationOtherInfo
        {
            get
            {
                return this.skinSensitisationOtherInfoField;
            }
            set
            {
                this.skinSensitisationOtherInfoField = value;
            }
        }
    }
}
