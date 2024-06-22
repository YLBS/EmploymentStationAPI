using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class EmailCheckFlag
    {
        public int MyUserId { get; set; }
        public bool? EmailFlag { get; set; }
        public int Type { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
