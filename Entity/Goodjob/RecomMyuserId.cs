using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class RecomMyuserId
    {
        public int MyuserId { get; set; }
        public string PerName { get; set; } = null!;
        public int Sex { get; set; }
        public int LocationP { get; set; }
        public int LocationC { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime ComDate { get; set; }
    }
}
