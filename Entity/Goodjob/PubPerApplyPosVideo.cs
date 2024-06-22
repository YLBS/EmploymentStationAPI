using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubPerApplyPosVideo
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int MemId { get; set; }
        public int VideoId { get; set; }
        public DateTime CreateDate { get; set; }
        public int ApplyCount { get; set; }
    }
}
