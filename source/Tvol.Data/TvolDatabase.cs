using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvol.Data
{
    public class TvolDatabase
    {

        //public static string IN_MEMORY_PATH = ":memory:";

        public string Path { get; set; }

        public TvolDatabase() { }

        public TvolDatabase(string path)
        {
            Path = path;
        }

        public string BuildConnectionString()
        {
            return $"Data Source={Path};";
        }

        public IDbConnection OpenConnection()
        {
            var connString = BuildConnectionString();
            var conn = new SqliteConnection(connString);
            conn.Open();

            return conn;
        }

        public void Create()
        {
            var connString = BuildConnectionString();

            using (var conn = new SqliteConnection(connString))
            {
                conn.Open();

                conn.Execute(TreeProfile.CREATE_TABLE);
                conn.Execute(Sale.CREATE_TABLE);
                conn.Execute(Tree.CREATE_TABLE);
                conn.Execute(Regression.CREATE_TABLE);
            }
        }
    }
}
