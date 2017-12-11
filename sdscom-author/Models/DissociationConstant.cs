﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    public class DissociationConstant
    {
        private PhysChemValueWithTemperature valueField;

        private UnitValue concentrationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemValueWithTemperature Value
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
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue Concentration
        {
            get
            {
                return this.concentrationField;
            }
            set
            {
                this.concentrationField = value;
            }
        }
    }
}
