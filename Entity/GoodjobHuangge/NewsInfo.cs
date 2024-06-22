using System;
using System.Collections.Generic;

namespace Entity.GoodjobHuangge
{
    public partial class NewsInfo
    {
        public int NewsId { get; set; }
        public string Title { get; set; } = null!;
        public string ArticleType { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public string Introduction { get; set; } = null!;
        public string ContentText { get; set; } = null!;
        public DateTime EditDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int HitCount { get; set; }
        public int Matk { get; set; }
        public int UserId { get; set; }
    }
}
