using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewPubMind
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Type { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public string? DptName { get; set; }
        public DateTime? InTime { get; set; }
        public int? RepeatEplId { get; set; }
        public string? RepeatEplName { get; set; }
        public string? RepeatContent { get; set; }
        public DateTime? RepeatTime { get; set; }
    }
}
