using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tvol.Data
{
    [Table(nameof(Sale))]
    public class Sale
    {
        public static readonly string CREATE_TABLE =
@"CREATE TABLE Sale (
SaleNumber INTEGER PRIMARY KEY);";

        [ExplicitKey]
        public int SaleNumber { get; set; } = 0;
    }
}
