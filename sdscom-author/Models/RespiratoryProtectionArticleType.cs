﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class RespiratoryProtectionArticleType
    {
        private Phrase[] equipmentForSelfRescueField;

        private Phrase[] maskTypeField;

        private Phrase[] filterApparatusTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentForSelfRescue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] EquipmentForSelfRescue
        {
            get
            {
                return this.equipmentForSelfRescueField;
            }
            set
            {
                this.equipmentForSelfRescueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaskType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] MaskType
        {
            get
            {
                return this.maskTypeField;
            }
            set
            {
                this.maskTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FilterApparatusType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] FilterApparatusType
        {
            get
            {
                return this.filterApparatusTypeField;
            }
            set
            {
                this.filterApparatusTypeField = value;
            }
        }
    }
}
