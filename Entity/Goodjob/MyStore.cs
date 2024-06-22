using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyStore
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string ContactPerson { get; set; } = null!;
        public string MobileNum { get; set; } = null!;
        public string StoreName { get; set; } = null!;
        public string Location { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 0正常 1待定 2待定 3删除 4黑名单
        /// </summary>
        public int StoreState { get; set; }
        public bool IsDell { get; set; }
        public string Email { get; set; } = null!;
    }
}
