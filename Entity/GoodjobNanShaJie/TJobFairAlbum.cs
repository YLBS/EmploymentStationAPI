using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class TJobFairAlbum
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string Originalpath { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public DateTime Addtime { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool ShowFlag { get; set; }
    }
}
