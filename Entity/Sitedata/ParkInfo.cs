using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    /// <summary>
    /// 珠宝园区信息
    /// </summary>
    public partial class ParkInfo
    {
        public int ParkId { get; set; }
        public string ParkName { get; set; } = null!;
        public string ParkIntroduction { get; set; } = null!;
        public string ParkProjectbrief { get; set; } = null!;
        public string ParkConfigurationinfo { get; set; } = null!;
        public string ParkStyle { get; set; } = null!;
        public string ParkContact { get; set; } = null!;
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int LocationP { get; set; }
        public int LocationC { get; set; }
        public int LocationT { get; set; }
        public string BannerUrl { get; set; } = null!;
        public string LogoUrl { get; set; } = null!;
    }
}
