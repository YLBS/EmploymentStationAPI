using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MemLibDownload
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public byte MemFlag { get; set; }
        public DateTime DownDate { get; set; }
    }
}
