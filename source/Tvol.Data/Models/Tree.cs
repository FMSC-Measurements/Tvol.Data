using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvol.Data
{
    [Table(nameof(Tree))]
    public class Tree
    {
        public static readonly string CREATE_TABLE =
@"CREATE TABLE Tree (
TreeID INTEGER PRIMARY KEY AUTOINCREMENT,
Species TEXT, 
Product INTEGER, 
DBH REAL,
Height REAL,
FOREIGN KEY (Species, Product) REFERENCES TreeProfile
);";

        public string Species { get; set; } = "";

        public int Product { get; set; } = 0;

        public double DBH { get; set; } = 0.0;

        public double Height { get; set; } = 0.0;

        TreeProfile _profile;
        public TreeProfile Profile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnProfileChanged();
            }
        }

        private void OnProfileChanged()
        {
            if(Profile != null)
            {
                //Species = Profile.Species;
                //Product = Profile.Product;
            }
        }
    }
}
