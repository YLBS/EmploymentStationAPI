using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewWebSiteBondManager
    {
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
        public string EplName { get; set; } = null!;
        public int DptId { get; set; }
        public int? InEplId { get; set; }
        public DateTime? InTime { get; set; }
        public string ClientName { get; set; } = null!;
        public string? Keyword { get; set; }
        public int? MemberId { get; set; }
        public int CsId { get; set; }
        public string? ClientHompage { get; set; }
        public int? ClientSpace { get; set; }
        public int EplId { get; set; }
        public int? InProvince { get; set; }
        public int? InCity { get; set; }
        public int? CraftType { get; set; }
        public string? RegMoney { get; set; }
        public string? Address { get; set; }
        public string? PhoneA { get; set; }
        public string? PhoneB { get; set; }
        public string? PhoneC { get; set; }
        public string? FaxA { get; set; }
        public string? FaxB { get; set; }
        public string? FaxC { get; set; }
        public string? Cinfo { get; set; }
        public string? SiteMemo { get; set; }
        public string? Clog { get; set; }
        public DateTime? Indate { get; set; }
        public DateTime? AbandonTime { get; set; }
        public DateTime? LastLinkDate { get; set; }
        public DateTime? DnsStime { get; set; }
        public DateTime? DnsEtime { get; set; }
        public DateTime? SpaceStime { get; set; }
        public DateTime? SpaceEtime { get; set; }
        public int? FinId { get; set; }
        public int Id { get; set; }
    }
}
