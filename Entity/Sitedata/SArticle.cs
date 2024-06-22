using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class SArticle
    {
        public int NewsId { get; set; }
        public int ClassId { get; set; }
        public int ClassParentId { get; set; }
        public int SiteId { get; set; }
        public string Title { get; set; } = null!;
        public string Contents { get; set; } = null!;
        public string CoreContent { get; set; } = null!;
        public string Keyword { get; set; } = null!;
        public string Tags { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public DateTime EditDate { get; set; }
        public int HitCount { get; set; }
        public int IssuerId { get; set; }
        public string IssuerName { get; set; } = null!;
        public byte HotFlag { get; set; }
    }
}
