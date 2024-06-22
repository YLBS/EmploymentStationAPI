using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewZphPoint
    {
        public int ZphPoints { get; set; }
        public string Instructions { get; set; } = null!;
        public int Audit { get; set; }
        public DateTime EditDate { get; set; }
        public int EplId { get; set; }
        public string ComName { get; set; } = null!;
        public string EplName { get; set; } = null!;
        public int ComId { get; set; }
        public int PointsId { get; set; }
        public int ComzphPoints { get; set; }
    }
}
