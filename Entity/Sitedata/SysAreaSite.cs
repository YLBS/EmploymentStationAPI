using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class SysAreaSite
    {
        public int SiteId { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public string SiteName { get; set; } = null!;
        public string Domain { get; set; } = null!;
        public string FolderName { get; set; } = null!;
        public bool Disabled { get; set; }
        public bool? Together { get; set; }
    }
}
