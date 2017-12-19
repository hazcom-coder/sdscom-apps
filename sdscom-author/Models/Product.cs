using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApps.Models 
{
    public class Product : BaseModel
    {
        public string Name { get; set; }

        public string OtherId { get; set; }

        public bool Active { get; set; }
    }
}
