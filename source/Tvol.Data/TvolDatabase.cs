using Dapper;
using Microsoft.Data.Sqlite;
using System.Data;

namespace Tvol.Data
{
    public class TvolDatabase
    {
        public const int LATEST_DB_VERSION = 1;

        //public static string IN_MEMORY_PATH = ":memory:";

        public string Path { get; set; }

        public int Version
        {
            get
            {
                using (var conn = OpenConnection())
                {
                    var version = conn.ExecuteScalar<int>("PRAGMA schema.USER_VERSION;");
                    return version;
                }
            }
        }

        public TvolDatabase()
        {
        }

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
                conn.Execute(Report.CREAT_TABLE);
                conn.Execute(Tree_Report.CREATE_TABLE);

                conn.Execute($"PRAGMA schema.user_version = {LATEST_DB_VERSION};");
            }
        }
    }
}