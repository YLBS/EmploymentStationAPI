using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubResumeBrowsedLog
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int MemId { get; set; }
        public int BrowsedCount { get; set; }
        public DateTime LatestBrowsedDate { get; set; }
        public bool DelFlag { get; set; }
        public bool IsRead { get; set; }
        public DateTime? PerTime { get; set; }
    }
}
