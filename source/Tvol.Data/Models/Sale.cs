﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tvol.Data
{
    public class Sale
    {
        public static readonly string CREATE_TABLE =
@"CREATE TABLE Sale (
SaleNumber INTEGER PRIMARY KEY);";

        public int SaleNumber { get; set; } = 0;
    }
}