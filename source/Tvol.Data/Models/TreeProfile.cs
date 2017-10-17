using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvol.Data
{
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
    }
}
