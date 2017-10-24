using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvol.Data
{
    public static class InsertExtentions
    {
        //public static void Insert(this IDbConnection conn, Regression data)
        //{
        //    data.ID = conn.ExecuteScalar<int>("INSERT INTO Regression " +
        //            "(Species, Product, DBHMin, DBHMax, RegressionModel, CoefficientA, CoefficientB, CoefficientC)" +
        //            "VALUES (@Species, @Product, @DBHMin, @DBHMax, @RegressionModel, @CoefficientA, @CoefficientB, @CoefficientC);" +
        //            "SELECT last_insert_rowid();");
        //}
    }
}
