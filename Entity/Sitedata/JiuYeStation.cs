using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class JiuYeStation
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string AffiliatedUnit { get; set; } = null!;
        public int AdminUser { get; set; }
        public int SecondaryUser { get; set; }
        public string Eaddress { get; set; } = null!;
        public int EaddressP { get; set; }
        public int EaddressC { get; set; }
        public int EaddressD { get; set; }
        public int EaddressT { get; set; }
        public string Introduce { get; set; } = null!;
        public DateTime UpDateTime { get; set; }
        public DateTime AddDateTime { get; set; }
        public string EaddressPname { get; set; } = null!;
        public string EaddressCname { get; set; } = null!;
        public string EaddressDname { get; set; } = null!;
        public string EaddressTname { get; set; } = null!;
        /// <summary>
        /// 驿站归属，1 大岗，2 南沙，4 黄阁
        /// </summary>
        public int BelongType { get; set; }
        public string ServiceQrcode { get; set; } = null!;
    }
}
