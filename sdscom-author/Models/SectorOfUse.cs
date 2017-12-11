﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    public class SectorOfUse
    {
        private SectorOfUseCodeEnum suCodeField;

        private Phrase suFulltextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SectorOfUseCodeEnum SuCode
        {
            get
            {
                return this.suCodeField;
            }
            set
            {
                this.suCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase SuFulltext
        {
            get
            {
                return this.suFulltextField;
            }
            set
            {
                this.suFulltextField = value;
            }
        }
    }

}
