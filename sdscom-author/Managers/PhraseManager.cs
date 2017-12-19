using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SDSComApps.Models;
using System.Xml.Schema;
using System.Reflection;
using Npgsql.PostgresTypes;
using Npgsql;
using System.Collections;

namespace SDSComApps.Managers
{



//      SELECT 
//      'INSERT INTO PHRASES (structure_code, region, english,german,revision_date) 
//      VALUES( ''' + structure_code + ''', ''' + region + ''' , ''' + REPLACE(english,'''','''''') + ''', '''
//      + REPLACE(german,'''','''''')  + ''', ''' + ISNULL(CAST(revision_date AS VARCHAR),'') + ''');'
//      FROM PHRASES

    public class PhraseManager
    {
        private readonly IConfiguration config;

        private DataManager dataMgr;

        public PhraseManager(IConfiguration _config)
        {
            this.config = _config;

            dataMgr = new DataManager(config);
        }

        public List<EuphracPhrase> Get()
        {  
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = @"SELECT * FROM phrases LIMIT 100";
            NpgsqlDataReader rdr = dataMgr.GetReader(cmd);

            return GetEuPhracPhraseFromReader(rdr);
        }

        public long GetCount()
        {
            long x = 0;
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = @"SELECT count(*) FROM public.phrases";
            x = dataMgr.Execute(cmd);

            return x;
        }


        private List<EuphracPhrase> GetEuPhracPhraseFromReader(NpgsqlDataReader rdr)
        {
            List<EuphracPhrase> phrases = new List<EuphracPhrase>();

            while (rdr.Read())
            {
                EuphracPhrase phrase = new EuphracPhrase
                {
                    EuPhraCStructureCode = rdr["structure_code"] as string,
                    English = rdr["english"] as string,
                    German = rdr["german"] as string
                };
                phrases.Add(phrase);
            }
            rdr.Close();
            return phrases;

        }

    }
}
