using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    public class PartitionCoefficient
    {
        private PhysChemUnitValueWithTemperature valueField;

        private Value phField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature Value
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Value Ph
        {
            get
            {
                return this.phField;
            }
            set
            {
                this.phField = value;
            }
        }
    }
}
