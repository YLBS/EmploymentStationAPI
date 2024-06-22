using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class BrandInfo
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;
        public string EnBrandName { get; set; } = null!;
        /// <summary>
        /// 9f 旧类别 未启用
        /// </summary>
        public string BrandType { get; set; } = null!;
        public string FoundDate { get; set; } = null!;
        public string Legalperson { get; set; } = null!;
        public string ContactTelZ { get; set; } = null!;
        public string ContactTel { get; set; } = null!;
        public string ContactTelE { get; set; } = null!;
        public string LogoUrl { get; set; } = null!;
        public string HomePage { get; set; } = null!;
        public string BrandIntroduction { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string Initial { get; set; } = null!;
        public int TotalScore { get; set; }
        public byte AdFlag { get; set; }
        public string PinYin { get; set; } = null!;
        public string Title { get; set; } = null!;
        public int HitCount { get; set; }
        public bool IsCommend { get; set; }
    }
}
