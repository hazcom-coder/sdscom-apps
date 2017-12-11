using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    /// <remarks/>
    public class OccupationalAirRequirement
    {

        private string oarGroupField;

        private string oarValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OarGroup
        {
            get
            {
                return this.oarGroupField;
            }
            set
            {
                this.oarGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OarValue
        {
            get
            {
                return this.oarValueField;
            }
            set
            {
                this.oarValueField = value;
            }
        }
    }
}
