using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Tvol.Data.Util;

namespace Tvol.Data
{
    [Table(nameof(Sale))]
    public class Sale : INPC_Base
    {
        public static readonly string CREATE_TABLE =
@"CREATE TABLE Sale (
[SaleNumber] INTEGER PRIMARY KEY);";

        private int _saleNumber = 0;

        [ExplicitKey]
        public int SaleNumber
        {
            get { return _saleNumber;  }
            set { SetValue(ref _saleNumber, value); }
        }
    }
}
