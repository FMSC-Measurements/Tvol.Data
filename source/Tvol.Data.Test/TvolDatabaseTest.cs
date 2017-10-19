using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using FluentAssertions;
using Xunit;

namespace Tvol.Data.Test
{
    public class TvolDatabaseTest : IDisposable
    {
        [Fact]
        public void CreateTest()
        {
            var db = new TvolDatabase("testCreate.db");

            db.Create();

            VerifyCreate(db);
        }

        private static void VerifyCreate(TvolDatabase db)
        {
            using (var conn = db.OpenConnection())
            {


                conn.Invoking(c => c.Execute("EXPLAIN SELECT * FROM Tree;")).ShouldNotThrow();
                conn.Invoking(c => c.Execute("EXPLAIN SELECT * FROM Regression;")).ShouldNotThrow();
                conn.Invoking(c => c.Execute("EXPLAIN SELECT * FROM TreeProfile;")).ShouldNotThrow();
                conn.Invoking(c => c.Execute("EXPLAIN SELECT * FROM Sale;")).ShouldNotThrow();
            }
        }

        public void Dispose()
        {
            System.IO.File.Delete("testCreate.db");
        }
    }
}
