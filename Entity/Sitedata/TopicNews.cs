using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class TopicNews
    {
        public int NewsId { get; set; }
        public string Title { get; set; } = null!;
        public string ContentText { get; set; } = null!;
        public DateTime EditDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int HitCount { get; set; }
        public byte AdFlag { get; set; }
        public int NewsType { get; set; }
    }
}
