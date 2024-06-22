using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyRecommendWx
    {
        public int Id { get; set; }
        public string? WxName { get; set; }
        public string? WxImage { get; set; }
        public int? MyUserId { get; set; }
        public int RecommendId { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ViewCount { get; set; }
        public string? XcxCode { get; set; }
    }
}
