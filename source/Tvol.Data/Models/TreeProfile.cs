using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvol.Data
{
    [Table(nameof(TreeProfile))]
    public class TreeProfile
    {
        public static readonly string CREATE_TABLE =
@"CREATE TABLE TreeProfile (
Species TEXT DEFAULT '',
Product INTEGER DEFAULT -1,
PRIMARY KEY (Species, Product)
);";

        public string Species { get; set; } = "";

        public int Product { get; set; } = 0;

        public override string ToString()
        {
            return $"Sp:{Species} Prod:{Product}";
        }
    }
}
