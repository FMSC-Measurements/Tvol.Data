using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tvol.Data.Util;

namespace Tvol.Data
{
    [Table(nameof(TreeProfile))]
    public class TreeProfile : INPC_Base
    {
        public static readonly string CREATE_TABLE =
@"CREATE TABLE TreeProfile (
[TreeProfileID] INTEGER PRIMARY KEY AUTOINCREMENT,
[Species] TEXT DEFAULT '',
[Product] INTEGER DEFAULT -1,
[LiveDead] TEXT DEFAULT '',
PRIMARY KEY ([Species], [Product], [LiveDead])
);";
        private string _species = "";
        private int _product = 0;
        private string _liveDead = "";

        [Key]
        public int TreeProfileID { get; set; }

        public string Species
        {
            get { return _species; }
            set {
                if (_species == value) return;
                SetValue(ref _species, value);
            }
        }

        public int Product
        {
            get { return _product; }
            set
            {
                if (_product == value) return;
                SetValue(ref _product, value);
            }
        }

        public string LiveDead
        {
            get { return _liveDead; }
            set
            {
                if (_liveDead == value) return;
                SetValue(ref _liveDead, value);
            }
        }

        public override string ToString()
        {
            return $"Sp:{Species} Prod:{Product} LiveDead:{LiveDead}";
        }
    }
}
