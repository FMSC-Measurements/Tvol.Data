using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvol.Data
{
    public static class RegressionModel
    {
        public const string LINEAR = "Linear";
        public const string QUADRATIC = "Quadratic";
        public const string LOG = "Log";
        public const string POWER = "Power";
    }

    [Table(nameof(Regression))]
    public class Regression
    {
        public static readonly string CREATE_TABLE =
@"CREATE TABLE Regression (
    RegressionID INTEGER PRIMARY KEY AUTOINCREMENT,
    Species TEXT,
    Product INTEGER,
    LiveDead TEXT,
    DBHMin REAL,
    DBHMax REAL,
    RegressionModel TEXT,
    CoefficientA REAL,
    CoefficientB REAL,
    CoefficientC REAL,
    FOREIGN KEY (Species, Product, LiveDead) REFERENCES TreeProfile ON DELETE CASCADE
);";

        
        [Key]
        public int RegressionID { get; set; }

        public string Species { get; set; } = "";

        public int Product { get; set; } = 0;

        public string LiveDead { get; set; }

        public double DBHMin { get; set; } = 0.0;

        public double DBHMax { get; set; } = 0.0;

        public string RegressionModel { get; set; } = "Unknown";

        public double CoefficientA { get; set; } = 0.0;

        public double CoefficientB { get; set; } = 0.0;

        public double CoefficientC { get; set; } = 0.0;

    }
}
