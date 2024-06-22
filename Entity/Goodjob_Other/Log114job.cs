using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class Log114job
    {
        public int Id { get; set; }
        public string ExportTo { get; set; } = null!;
        public DateTime ExportDate { get; set; }
        public int Job { get; set; }
        public int Company { get; set; }
        public int Resume { get; set; }
    }
}
