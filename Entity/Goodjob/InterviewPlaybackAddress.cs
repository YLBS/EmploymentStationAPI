using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class InterviewPlaybackAddress
    {
        public int Id { get; set; }
        public string Cname { get; set; } = null!;
        public int MemId { get; set; }
        public int ZhpId { get; set; }
        public int MyUserId { get; set; }
        public string FileList { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
    }
}
