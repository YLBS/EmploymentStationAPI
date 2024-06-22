using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class WebSiteBondManager
    {
        public int Id { get; set; }
        public string BondNo { get; set; } = null!;
        public decimal? BondMoney { get; set; }
        public int? ClientId { get; set; }
        public string? Dns { get; set; }
        public DateTime? DnsBeginTime { get; set; }
        public DateTime? DnsEndTime { get; set; }
        public string? WebSpace { get; set; }
        public DateTime? SpaceBeginTime { get; set; }
        public DateTime? SpaceEndTime { get; set; }
        public string? Remark { get; set; }
        public string? WorkFile { get; set; }
        public byte? CheckState { get; set; }
        public int? CheckEplId { get; set; }
        public string? CheckName { get; set; }
        public DateTime? CheckTime { get; set; }
        public string? CheckMemo { get; set; }
        public int? InEplId { get; set; }
        public DateTime? InTime { get; set; }
    }
}
