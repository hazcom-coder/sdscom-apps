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
        private string connString;

        public DataManager(IConfiguration _config)
        {
            this.config = _config;

            connString = config["ConnectionStrings:SDSCOM"];

            NpgsqlConnection conn = new NpgsqlConnection(connString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();


            conn.Close();

        }

        public int Execute(NpgsqlCommand cmd, bool ReturnId = false , string ReturnField = "")
        {
            int ret = 0;

            if(ReturnId)
            {
                if (string.IsNullOrEmpty(ReturnField))
                {
                    ReturnField = "ID";
                }
                cmd.CommandText = cmd.CommandText + " ; RETURNING " + ReturnField + " ; ";
            }

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                cmd.Connection = conn;

                try
                {
                    ret = cmd.ExecuteNonQuery();
                }
                catch (NpgsqlException ex)
                {
                    Console.Write(ex.Message);
                }
                finally { conn.Close(); }
            }
            return ret;
        }

        /// <summary>
        /// Close it when done
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public NpgsqlDataReader GetReader(NpgsqlCommand cmd)
        {
            NpgsqlDataReader rdr = null;

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                rdr = cmd.ExecuteReader();
                
                conn.Close();
            }

            return rdr;
        }




    }
}
