using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    public class PhysicalHazardsScreeningProcedures
    {
        private Phrase screeningTypeField;

        private PhysChemUnitValue screeningResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ScreeningType
        {
            get
            {
                return this.screeningTypeField;
            }
            set
            {
                this.screeningTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue ScreeningResult
        {
            get
            {
                return this.screeningResultField;
            }
            set
            {
                this.screeningResultField = value;
            }
        }
    }



}
