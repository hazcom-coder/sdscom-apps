using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using Npgsql.PostgresTypes;
using Npgsql.Schema;
using NpgsqlTypes;
using Npgsql.NameTranslation;
using Microsoft.Extensions.Configuration;

namespace SDSComApp.Managers
{
    public class DataManager
    {
        private readonly IConfiguration config;

        public DataManager(IConfiguration _config)
        {
            this.config = _config;

            string cs = config["ConnectionStrings:SDSCOM"];

            NpgsqlConnection conn = new NpgsqlConnection(cs);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.CommandText = "SELECT count(*) FROM PRODUCTS";
            cmd.Connection = conn;
            object x = cmd.ExecuteScalar();

            conn.Close();

        }




    }
}
