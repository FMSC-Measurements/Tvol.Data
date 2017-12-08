using Dapper.Contrib.Extensions;

namespace Tvol.Data
{
    public static class RegressModel
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
    [RegressionID] INTEGER PRIMARY KEY AUTOINCREMENT,
    [Species] TEXT,
    [Product] INTEGER,
    [LiveDead] TEXT,
    [DBHMin] REAL,
    [DBHMax] REAL,
    [RegressModel] TEXT DEFAULT 'Unknown',
    [CoefficientA] REAL,
    [CoefficientB] REAL,
    [CoefficientC] REAL,
    [Volume] TEXT DEFAULT 'Unknown',
    [VolType] TEXT DEFAULT 'Unknown',
    FOREIGN KEY ([Species], [Product], [LiveDead]) REFERENCES TreeProfile ON DELETE CASCADE
);";

        [Key]
        public int RegressionID { get; set; }

        public string Species { get; set; } = "";

        public int Product { get; set; } = 0;

        public string LiveDead { get; set; }

        public double DBHMin { get; set; } = 0.0;

        public double DBHMax { get; set; } = 0.0;

        public string RegressModel { get; set; } = "Unknown";

        public double CoefficientA { get; set; } = 0.0;

        public double CoefficientB { get; set; } = 0.0;

        public double CoefficientC { get; set; } = 0.0;

        public string Volume { get; set; } = "Unknown";

        public string VolType { get; set; } = "Unknown";
    }
}