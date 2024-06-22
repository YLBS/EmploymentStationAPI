using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphMemContactInfoPay
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public int MemId { get; set; }
        public string Mobile { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string ContactPerson { get; set; } = null!;
        public DateTime? UpDate { get; set; }
        public string HealthCode { get; set; } = null!;
        public string TripCode { get; set; } = null!;
        public string Idcard { get; set; } = null!;
        public string LicensePlate { get; set; } = null!;
        public string OrderString { get; set; } = null!;
        public string PosIds { get; set; } = null!;
        public string LandLine { get; set; } = null!;
        /// <summary>
        /// 是否印刷到海报上 0 不显示 ； 1 用手机号 ； 2 用座机 ; 3 两个都加上去
        /// </summary>
        public int PosterPrintFlag { get; set; }
    }
}
