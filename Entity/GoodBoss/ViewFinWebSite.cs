using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewFinWebSite
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public decimal? HowCost { get; set; }
        public string? Remark { get; set; }
        public DateTime? InTime { get; set; }
        public int? AdminUser { get; set; }
        public string? AdminName { get; set; }
        public string? AdminIp { get; set; }
        public string? ClientName { get; set; }
        public string? Keyword { get; set; }
        public int? MemberId { get; set; }
        public int? CsId { get; set; }
        public string? ClientHompage { get; set; }
        public int? ClientSpace { get; set; }
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
        public int? ClientEplId { get; set; }
        public int? FinProperty { get; set; }
        public string? FinPropertyName { get; set; }
    }
}
