using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class CrmErmemployee
    {
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public int PosId { get; set; }
        public int DptId { get; set; }
        public string WeiXinHao { get; set; } = null!;
        public string DptName { get; set; } = null!;
    }
}
