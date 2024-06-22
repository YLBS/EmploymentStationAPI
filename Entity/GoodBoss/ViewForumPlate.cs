using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewForumPlate
    {
        public int PlateId { get; set; }
        public int? ParentId { get; set; }
        public string PlateName { get; set; } = null!;
        public string? PlateStyle { get; set; }
        public int PlateOrder { get; set; }
        public DateTime? InTime { get; set; }
        public byte? Type { get; set; }
    }
}
