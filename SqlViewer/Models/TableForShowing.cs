using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlViewer.Models
{
    public class TableForShowing
    {
        public string columnName { get; set; }
        public string columnValue { get; set; }
        public string error { get; set; }

        public override string ToString()=>$"{columnName} {columnValue}";
    }
}
