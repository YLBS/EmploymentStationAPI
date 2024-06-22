using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewDevClient
    {
        public int ClientId { get; set; }
        public string ClientTypeName { get; set; } = null!;
        public int MemberId { get; set; }
        public string OwnerName { get; set; } = null!;
        public string ClientName { get; set; } = null!;
        public string ClientInfo { get; set; } = null!;
        public string Website { get; set; } = null!;
        public string WebDomain { get; set; } = null!;
        public int WebRank { get; set; }
        public string ProvinceName { get; set; } = null!;
        public string CityName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Postalcode { get; set; } = null!;
        public string Linkman { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Qq { get; set; } = null!;
        public string Msn { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string TransferLog { get; set; } = null!;
        public int LastTrackId { get; set; }
        public DateTime? GiveupDate { get; set; }
        public DateTime? LastTrackDate { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
