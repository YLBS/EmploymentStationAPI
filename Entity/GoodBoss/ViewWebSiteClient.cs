using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewWebSiteClient
    {
        public int CsId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; } = null!;
        public int? MemberId { get; set; }
        public string? ClientHompage { get; set; }
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
        public int? FinId { get; set; }
        public DateTime? SpaceEtime { get; set; }
        public string? CsName { get; set; }
        public string? Pname { get; set; }
        public string? CityName { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public int? ClientSpace { get; set; }
        public string? Keyword { get; set; }
        public string? CraftName { get; set; }
        public bool? IsCoin { get; set; }
    }
}
