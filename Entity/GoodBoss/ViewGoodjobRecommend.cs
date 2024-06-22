using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewGoodjobRecommend
    {
        public string EplName { get; set; } = null!;
        public int ComId { get; set; }
        public int MemId { get; set; }
        public int SourceId { get; set; }
        public string SourceMyUserId { get; set; } = null!;
        public int MyUserId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime ApplicationDate { get; set; }
        public DateTime ProcessingDate { get; set; }
        public int SendType { get; set; }
        public int Processing { get; set; }
        public int EplId { get; set; }
        public int Id { get; set; }
        public string ComName { get; set; } = null!;
        public int DateId { get; set; }
    }
}
