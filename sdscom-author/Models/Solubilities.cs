﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class SolubilitiesSolubility
    {

        private SolubilityMediumEnum mediumField;

        private Phrase otherMediumDescriptionField;

        private PhysChemUnitValueWithTemperature[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SolubilityMediumEnum Medium
        {
            get
            {
                return this.mediumField;
            }
            set
            {
                this.mediumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase OtherMediumDescription
        {
            get
            {
                return this.otherMediumDescriptionField;
            }
            set
            {
                this.otherMediumDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] Value
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
    }



    public class Solubilities
    {
        private Phrase[] solubilityDescriptionField;

        private SolubilitiesSolubility[] solubilityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SolubilityDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SolubilityDescription
        {
            get
            {
                return this.solubilityDescriptionField;
            }
            set
            {
                this.solubilityDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Solubility", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SolubilitiesSolubility[] Solubility
        {
            get
            {
                return this.solubilityField;
            }
            set
            {
                this.solubilityField = value;
            }
        }
    }
}
