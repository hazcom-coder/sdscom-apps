using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using System.Data;
using SDSComApps.Models;


namespace SDSComApps.Managers
{
    /// <summary>
    /// 
    /// </summary>
    public class UserManager : BaseManager
    {
        private readonly IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public UserManager(IConfiguration _config, IMemoryCache _cache) : base(_config, _cache)
        {
            config = _config;
            cache = _cache;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public User GetByID(int userid)
        {
            User user = new User();
            using (IDbConnection db = DbFactory.Open())
            {
                user = db.SingleById<User>(userid);
            }
            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public User GetByName(string username)
        {
            User user = new User();
            using (IDbConnection db = DbFactory.Open())
            {
                user = db.Select<User>(x => x.UserName == username).FirstOrDefault();
            }
            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<User> GetList()
        {
            List<User> userList = new List<User>();
            using (IDbConnection db = DbFactory.Open())
            {
                userList = db.Select<User>();
            }
            return userList;
        }
    }
}
