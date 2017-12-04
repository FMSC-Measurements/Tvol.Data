using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvol.Data
{
    [Table("Report")]
    public class Report
    {
        public static readonly string CREAT_TABLE = 
@"CREATE TABLE Reports (
    ReportID INTEGER PRIMARY KEY AUTOINCREMENT,
    CreatedDate DATETIME
);";

        [Key]
        public int ReportID { get; set; }

        public string CreatedDate { get; set; }
    }
}
