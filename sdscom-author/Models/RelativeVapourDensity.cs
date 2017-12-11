using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{

    public class RelativeVapourDensity
    {
        private PhysChemUnitValueWithTemperature valueField;

        private Phrase referenceGasField;

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
        public Phrase ReferenceGas
        {
            get
            {
                return this.referenceGasField;
            }
            set
            {
                this.referenceGasField = value;
            }
        }
    }
}
