using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class DevClient
    {
        public int ClientId { get; set; }
        public int ClientTypeId { get; set; }
        public int? MemberId { get; set; }
        public int Owner { get; set; }
        public bool? HaveOwner { get; set; }
        public string ClientName { get; set; } = null!;
        public string? ClientInfo { get; set; }
        public string? Website { get; set; }
        public string? WebDomain { get; set; }
        public int? WebRank { get; set; }
        public int LocalProvince { get; set; }
        public int? LocalCity { get; set; }
        public string? Address { get; set; }
        public string? Postalcode { get; set; }
        public string Linkman { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? PhoneArea { get; set; }
        public string? PhoneUser { get; set; }
        public string? PhoneExt { get; set; }
        public string? Fax { get; set; }
        public string? Qq { get; set; }
        public string? Msn { get; set; }
        public string? Email { get; set; }
        public int? LastTrackId { get; set; }
        public DateTime? LastTrackDate { get; set; }
        public DateTime? GiveupDate { get; set; }
        public DateTime? GetDate { get; set; }
        public string? TransferLog { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
