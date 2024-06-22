using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewDevFirstClient
    {
        public int ClientId { get; set; }
        public int MemberId { get; set; }
        public string ClientName { get; set; } = null!;
        public string ClientInfo { get; set; } = null!;
        public string Website { get; set; } = null!;
        public string WebDomain { get; set; } = null!;
        public int WebRank { get; set; }
        public string Address { get; set; } = null!;
        public string Postalcode { get; set; } = null!;
        public string Linkman { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string PhoneArea { get; set; } = null!;
        public string PhoneUser { get; set; } = null!;
        public string PhoneExt { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Qq { get; set; } = null!;
        public string Msn { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string TransferLog { get; set; } = null!;
        public int LastTrackId { get; set; }
        public DateTime? GiveupDate { get; set; }
        public DateTime? LastTrackDate { get; set; }
        public int ClientTypeId { get; set; }
        public int Owner { get; set; }
        public int LocalProvince { get; set; }
        public int? LocalCity { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
