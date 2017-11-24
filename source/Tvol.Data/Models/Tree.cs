using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tvol.Data.Util;

namespace Tvol.Data
{
    [Table(nameof(Tree))]
    public class Tree : INPC_Base
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
        private string _species = "";
        private int _product = 0;
        private double _dbh = 0.0;
        private double _height = 0.0;

        [Key]
        public int TreeID { get; set; }

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

        public double DBH
        {
            get { return _dbh; }
            set { SetValue(ref _dbh, value); }
        }

        public double Height
        {
            get { return _height; }
            set { SetValue(ref _height, value); }
        }

        //TreeProfile _profile;
        //public TreeProfile Profile
        //{
        //    get { return _profile; }
        //    set
        //    {
        //        _profile = value;
        //        OnProfileChanged();
        //    }
        //}

        //private void OnProfileChanged()
        //{
        //    if(Profile != null)
        //    {
        //        Species = Profile.Species;
        //        Product = Profile.Product;
        //    }
        //}
    }
}
