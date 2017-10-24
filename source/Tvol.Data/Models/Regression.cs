using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvol.Data
{
    [Table(nameof(Regression))]
    public class Regression
    {
        public static readonly string CREATE_TABLE =
@"CREATE TABLE Regression (
RegressionID INTEGER PRIMARY KEY AUTOINCREMENT,
Species TEXT,
Product INTEGER,
DBHMin REAL,
DBHMax REAL,
RegressionModel TEXT,
CoefficientA REAL,
CoefficientB REAL,
CoefficientC REAL,
FOREIGN KEY (Species, Product) REFERENCES TreeProfile ON DELETE CASCADE
);";

        public int ID { get; set; }

        public string Species { get; set; } = "";

        public int Product { get; set; } = 0;

        public double DBHMin { get; set; } = 0.0;

        public double DBHMax { get; set; } = 0.0;

        public string RegressionModel { get; set; } = "Unknown";

        public double CoefficientA { get; set; } = 0.0;

        public double CoefficientB { get; set; } = 0.0;

        public double CoefficientC { get; set; } = 0.0;

    }
}
