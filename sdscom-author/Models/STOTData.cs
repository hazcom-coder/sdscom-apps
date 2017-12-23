﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApps.Models
{
    /// <remarks/>
    public class STOTData
    {
        private ToxicityTypeEnum toxicityTypeField;

        private Phrase methodField;

        private ExposureRouteEnum exposureRouteField;

        private bool exposureRouteFieldSpecified;

        private UnitValue doseField;

        private UnitValue exposureTimeField;

        private UnitValue testDurationField;

        private UnitValue exposureFrequencyField;

        private Species speciesField;

        private Phrase[] specificEffectField;

        private Phrase[] organAffectedField;

        private UnitValue resultField;

        private Phrase[] resultEvaluationField;

        private Phrase testReferenceField;

        private Phrase[] commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExposureRouteSpecified
        {
            get
            {
                return this.exposureRouteFieldSpecified;
            }
            set
            {
                this.exposureRouteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue Dose
        {
            get
            {
                return this.doseField;
            }
            set
            {
                this.doseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue TestDuration
        {
            get
            {
                return this.testDurationField;
            }
            set
            {
                this.testDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue ExposureFrequency
        {
            get
            {
                return this.exposureFrequencyField;
            }
            set
            {
                this.exposureFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElement("SpecificEffect", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SpecificEffect
        {
            get
            {
                return this.specificEffectField;
            }
            set
            {
                this.specificEffectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OrganAffected", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OrganAffected
        {
            get
            {
                return this.organAffectedField;
            }
            set
            {
                this.organAffectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ResultEvaluation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ResultEvaluation
        {
            get
            {
                return this.resultEvaluationField;
            }
            set
            {
                this.resultEvaluationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElement("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
}
