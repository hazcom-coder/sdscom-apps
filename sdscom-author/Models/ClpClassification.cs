using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ClpClassification
    {

        private ClpHazardClassification[] clpHazardClassificationField;

        private Phrase[] clpClassificationCommentsField;

        private Phrase[] clpClassificationNotesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClpHazardClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClpHazardClassification[] ClpHazardClassification
        {
            get
            {
                return this.clpHazardClassificationField;
            }
            set
            {
                this.clpHazardClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClpClassificationComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ClpClassificationComments
        {
            get
            {
                return this.clpClassificationCommentsField;
            }
            set
            {
                this.clpClassificationCommentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClpClassificationNotes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ClpClassificationNotes
        {
            get
            {
                return this.clpClassificationNotesField;
            }
            set
            {
                this.clpClassificationNotesField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ClpHazardClassification
    {

        private HazardClassCategoryEnum clpHazardClassCategoryField;

        private HazardStatement[] clpHazardStatementField;

        private Phrase clpClassificationProcedureField;

        private MultiplyingFactor multiplyingFactorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardClassCategoryEnum ClpHazardClassCategory
        {
            get
            {
                return this.clpHazardClassCategoryField;
            }
            set
            {
                this.clpHazardClassCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClpHazardStatement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardStatement[] ClpHazardStatement
        {
            get
            {
                return this.clpHazardStatementField;
            }
            set
            {
                this.clpHazardStatementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ClpClassificationProcedure
        {
            get
            {
                return this.clpClassificationProcedureField;
            }
            set
            {
                this.clpClassificationProcedureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MultiplyingFactor MultiplyingFactor
        {
            get
            {
                return this.multiplyingFactorField;
            }
            set
            {
                this.multiplyingFactorField = value;
            }
        }
    }

    public class HazardStatement
    {

        private HazardStatementEnum phraseCodeField;

        private string fullTextField;

        private MergePhrase[] mergePhraseField;

        private string phraseIdField;

        private string phraseCatalogueIdField;

        public HazardStatement()
        {
            this.phraseCatalogueIdField = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardStatementEnum PhraseCode
        {
            get
            {
                return this.phraseCodeField;
            }
            set
            {
                this.phraseCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FullText
        {
            get
            {
                return this.fullTextField;
            }
            set
            {
                this.fullTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MergePhrase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MergePhrase[] MergePhrase
        {
            get
            {
                return this.mergePhraseField;
            }
            set
            {
                this.mergePhraseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhraseId
        {
            get
            {
                return this.phraseIdField;
            }
            set
            {
                this.phraseIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string PhraseCatalogueId
        {
            get
            {
                return this.phraseCatalogueIdField;
            }
            set
            {
                this.phraseCatalogueIdField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ClassificationDpdDsdClassification
    {

        private ClassificationDpdDsdClassificationDpdDsdHazardClassification[] dpdDsdHazardClassificationField;

        private Phrase[] dpdDsdClassificationCommentsField;

        private Phrase[] dpdDsdClassificationNotesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DpdDsdHazardClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClassificationDpdDsdClassificationDpdDsdHazardClassification[] DpdDsdHazardClassification
        {
            get
            {
                return this.dpdDsdHazardClassificationField;
            }
            set
            {
                this.dpdDsdHazardClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DpdDsdClassificationComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] DpdDsdClassificationComments
        {
            get
            {
                return this.dpdDsdClassificationCommentsField;
            }
            set
            {
                this.dpdDsdClassificationCommentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DpdDsdClassificationNotes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] DpdDsdClassificationNotes
        {
            get
            {
                return this.dpdDsdClassificationNotesField;
            }
            set
            {
                this.dpdDsdClassificationNotesField = value;
            }
        }
    }


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ClassificationDpdDsdClassificationDpdDsdHazardClassification
    {

        private ClassificationCategoryEnum dpdDsdClassificationCategoryField;

        private bool dpdDsdClassificationCategoryFieldSpecified;

        private RiskPhrase[] dpdDsdRiskPhraseField;

        private DpdDsdHazardClassificationMultiplyingFactor multiplyingFactorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClassificationCategoryEnum DpdDsdClassificationCategory
        {
            get
            {
                return this.dpdDsdClassificationCategoryField;
            }
            set
            {
                this.dpdDsdClassificationCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DpdDsdClassificationCategorySpecified
        {
            get
            {
                return this.dpdDsdClassificationCategoryFieldSpecified;
            }
            set
            {
                this.dpdDsdClassificationCategoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DpdDsdRiskPhrase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RiskPhrase[] DpdDsdRiskPhrase
        {
            get
            {
                return this.dpdDsdRiskPhraseField;
            }
            set
            {
                this.dpdDsdRiskPhraseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdDsdHazardClassificationMultiplyingFactor MultiplyingFactor
        {
            get
            {
                return this.multiplyingFactorField;
            }
            set
            {
                this.multiplyingFactorField = value;
            }
        }
    }

}
