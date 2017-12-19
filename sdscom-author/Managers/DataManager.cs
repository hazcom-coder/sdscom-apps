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

namespace SDSComApps.Managers
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

        public Int64 Execute(NpgsqlCommand cmd, bool ReturnId = false , string ReturnField = "")
        {
            Int64 ret = 0;

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
                    ret = (Int64)cmd.ExecuteScalar();
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

            NpgsqlConnection conn = new NpgsqlConnection(connString);
            try
            { 
                conn.Open();
                cmd.Connection = conn;
                rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                Console.Write(ex.Message);
            }
           
            return rdr;
        }

    }
}
