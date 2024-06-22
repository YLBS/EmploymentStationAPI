using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class TJobFairInfo
    {
        public int Pid { get; set; }
        public string Title { get; set; } = null!;
        public string Scale { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public bool ShowLogo { get; set; }
        public string Hostunit { get; set; } = null!;
        public DateTime BenigDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Content { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int HotCount { get; set; }
        public bool IsAlbum { get; set; }
        public int SalaId { get; set; }
        public string Note { get; set; } = null!;
    }
}
