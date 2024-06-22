using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngPartnerUser
    {
        public int PartnerId { get; set; }
        public int SiteId { get; set; }
        public string PartnerName { get; set; } = null!;
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string SiteName { get; set; } = null!;
        public string? SiteDomain { get; set; }
        public int LocationP { get; set; }
        public int LocationC { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Opened { get; set; }
        public bool Disabled { get; set; }
        public DateTime? DisableDate { get; set; }
        public string LastLoginIp { get; set; } = null!;
        public DateTime LastLoginDate { get; set; }
        public string FolderName { get; set; } = null!;
        public bool Together { get; set; }
        public string Keyword { get; set; } = null!;
    }
}
