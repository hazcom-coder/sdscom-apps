using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SDSComApps.Models 
{
    /// <summary>
    /// Base object for sDSCom applications. this type includes Products and Components
    /// </summary>
    
    public class Entity 
    {
        /// <summary>
        /// 
        /// </summary>
        [AutoIncrement]
        [PrimaryKey]
        public long ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateStamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OtherId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int EntityType { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class EntityType
    {
        /// <summary>
        /// 
        /// </summary>
        [AutoIncrement]
        [PrimaryKey]
        public int ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EntityTypeName { get; set; }
    }
}
