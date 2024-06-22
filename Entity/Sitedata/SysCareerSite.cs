using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class SysCareerSite
    {
        public int SiteId { get; set; }
        public string SiteName { get; set; } = null!;
        public string Domain { get; set; } = null!;
        public string SitePath { get; set; } = null!;
        public string FolderName { get; set; } = null!;
        public bool Disabled { get; set; }
    }
}
