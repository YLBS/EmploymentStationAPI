using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmCsLog
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int EplId { get; set; }
        public string? EplName { get; set; }
        public DateTime Cgetdate { get; set; }
        public int FCsId { get; set; }
        public int TCsId { get; set; }
        public int OperId { get; set; }
        public string OperMode { get; set; } = null!;
        public int OEplId { get; set; }
        public string OEplName { get; set; } = null!;
        public string OEplIp { get; set; } = null!;
        public DateTime RegisterDate { get; set; }
    }
}
