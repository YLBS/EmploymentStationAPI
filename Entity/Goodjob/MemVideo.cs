using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemVideo
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        /// <summary>
        /// 0未分类  1 招聘类 2职场类
        /// </summary>
        public int Vtype { get; set; }
        public DateTime CreateDate { get; set; }
        public string VideoUrl { get; set; } = null!;
        public DateTime? CheckDate { get; set; }
        /// <summary>
        /// 0待审核 1通过 2拒绝
        /// </summary>
        public int? CheckFlag { get; set; }
        public int? CheckUserId { get; set; }
        public int Vlength { get; set; }
        public string MemName { get; set; } = null!;
        public string CompanyIntroduction { get; set; } = null!;
        /// <summary>
        /// 0 待处理 1 上线 2下线
        /// </summary>
        public int OnlineState { get; set; }
        public DateTime? OfflineDate { get; set; }
        public DateTime? OnlineDate { get; set; }
        public bool IsSys { get; set; }
        public int ViewCount { get; set; }
        public int UploadUserId { get; set; }
        public int CommentCount { get; set; }
        public int ForwardCount { get; set; }
        public int ApplyCount { get; set; }
        public int FabulousCount { get; set; }
        public int PlayCount { get; set; }
        public string CoverUrl { get; set; } = null!;
        public string Address { get; set; } = null!;
        public bool IsDell { get; set; }
        public DateTime? RefreshDate { get; set; }
        public bool IsTop { get; set; }
        public DateTime? TopDate { get; set; }
        public int? DelayCount { get; set; }
    }
}
