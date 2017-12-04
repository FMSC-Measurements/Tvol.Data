using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvol.Data
{
    public class Tree_Report
    {
        public static readonly string CREATE_TABLE =
@"
CREATE TABLE Tree_Report
(
    TreeID INTEGER,
    ReportID INTEGER,
    FOREIGN KEY (TreeID) REFERENCES Tree ON DELETE CASCADE,
    FOREIGN KEY (ReportID) REFERENCES Report ON DELETE CASCADE,
    UNIQUE (TreeID)
);";

        [Key]
        public int RowID { get; set; }

        public int TreeID { get; set; }

        public int ReportID { get; set; }
    }
}
