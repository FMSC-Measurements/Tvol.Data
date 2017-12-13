using Dapper.Contrib.Extensions;
using Tvol.Data.Util;

namespace Tvol.Data
{
    public static class RegressModel
    {
        public const string DEFAULT = "Unknown";
        public const string LINEAR = "Linear";
        public const string QUADRATIC = "Quadratic";
        public const string LOG = "Log";
        public const string POWER = "Power";
    }

    [Table(nameof(Regression))]
    public class Regression : INPC_Base
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

        private string _species = "";
        private int _product = 0;
        private string _liveDead;
        private double _dbhMin = 0.0;
        private double _dbhMax = 0.0;
        private string _regressModel = "Unknown";
        private double _coefficientA = 0.0;
        private double _coefficientB = 0.0;
        private double _coefficientC = 0.0;
        private string _volume = "Unknown";

        [Key]
        public int RegressionID { get; set; }

        public string Species
        {
            get { return _species; }
            set { SetValue(ref _species, value); }
        }

        public int Product
        {
            get { return _product; }
            set { SetValue(ref _product, value); }
        }

        public string LiveDead
        {
            get { return _liveDead; }
            set { SetValue(ref _liveDead, value); }
        }

        public double DBHMin
        {
            get { return _dbhMin; }
            set { SetValue(ref _dbhMin, value); }
        }

        public double DBHMax
        {
            get { return _dbhMax; }
            set { SetValue(ref _dbhMax, value); }
        }

        public string RegressModel
        {
            get { return _regressModel; }
            set { SetValue(ref _regressModel, value); }
        }

        public double CoefficientA
        {
            get { return _coefficientA; }
            set { SetValue(ref _coefficientA, value); }
        }

        public double CoefficientB
        {
            get { return _coefficientB; }
            set { SetValue(ref _coefficientB, value); }
        }

        public double CoefficientC
        {
            get { return _coefficientC; }
            set { SetValue(ref _coefficientC, value); }
        }

        public string Volume
        {
            get { return _volume; }
            set { SetValue(ref _volume, value); }
        }

        public string VolType
        {
            get;
            set;
        }
    }
}