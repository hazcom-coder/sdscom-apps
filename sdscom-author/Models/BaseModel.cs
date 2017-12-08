using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{
    public class BaseModel
    {
        public int ID { get; set; }

        public int UserId {get; set;}

        public DateTime DateStamp {get; set;}
    }
}
