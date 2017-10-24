using Dapper;
using Dapper.Contrib.Extensions;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tvol.Data.Test.Model
{
    public class RegressionTest : IDisposable
    {
        TvolDatabase _database;
        string _dbPath; 

        public RegressionTest()
        {
            try
            {
                _dbPath = System.IO.Path.GetFullPath("RegressionTest.db");
                _database = new TvolDatabase(_dbPath);
                _database.Create();

                using (var conn = _database.OpenConnection())
                {
                    TreeProfile tp;
                    //conn.Insert(tp = new TreeProfile() { Species = "sp", Product = 1 });
                    conn.Insert(new Regression() { Species = "sp", Product = 1 });
                    
                }
            }
            catch(Exception e)
            {
                System.IO.File.Delete(_dbPath);
                throw;
            }
        }

        [Fact]
        public void ReadTest()
        {
            using (var conn = _database.OpenConnection())
            {
                var result = conn.Query<Regression>("SELECT * FROM Regression;").FirstOrDefault();

                result.Should().NotBeNull();
                result.Species.ShouldBeEquivalentTo("sp");
                result.Product.ShouldBeEquivalentTo(1);
            }
        }

        [Fact]
        public void InsertTest()
        {
            using (var conn = _database.OpenConnection())
            {
                var value = new Regression() { Species = "testSp", Product = 1, RegressionModel = "test"};
                conn.Insert(value);

                value.ID.Should().BeGreaterThan(0);

                var reslut = conn.Query<Regression>("SELECT * FROM Regression WHERE Species = 'testSp'").FirstOrDefault();

                reslut.Should().NotBeNull();
                reslut.Species.ShouldBeEquivalentTo("testSp");
                reslut.RegressionModel.ShouldBeEquivalentTo("test");
                reslut.Product.ShouldBeEquivalentTo(1);
            }
        }

        public void Dispose()
        {
            System.IO.File.Delete(_dbPath);
        }
    }
}
