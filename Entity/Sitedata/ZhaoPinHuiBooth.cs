using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZhaoPinHuiBooth
    {
        /// <summary>
        /// 0
        /// </summary>
        public int Id { get; set; }
        public string Region { get; set; } = null!;
        public int MaxNumber { get; set; }
        public int MinNumber { get; set; }
        public DateTime CreateTime { get; set; }
        public int Pid { get; set; }
        public int AdminId { get; set; }
        public int OrderSafe { get; set; }
        public bool IsDisable { get; set; }
        public bool IsDell { get; set; }
    }
}
