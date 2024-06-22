using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class GoodjobRecommendBack
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int EplId { get; set; }
        public int MemId { get; set; }
        public int SourceId { get; set; }
        public string SourceMyUserId { get; set; } = null!;
        public int MyUserId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime ApplicationDate { get; set; }
        public DateTime ProcessingDate { get; set; }
        public int SendType { get; set; }
        public int Processing { get; set; }
        public int DateId { get; set; }
        public int IsDelete { get; set; }
        public int UpEplId { get; set; }
    }
}
