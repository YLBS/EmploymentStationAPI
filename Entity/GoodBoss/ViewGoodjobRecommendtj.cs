using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewGoodjobRecommendtj
    {
        public int UpEplId { get; set; }
        public DateTime ProcessingDate { get; set; }
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public int ComId { get; set; }
        public string ComName { get; set; } = null!;
        public int Id { get; set; }
        public string SourceMyUserId { get; set; } = null!;
        public int SourceId { get; set; }
    }
}
