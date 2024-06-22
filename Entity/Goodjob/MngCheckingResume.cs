using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngCheckingResume
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string PerName { get; set; } = null!;
        public int Sex { get; set; }
        public int Age { get; set; }
        public int LocationP { get; set; }
        public int LocationC { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public byte CheckFlag { get; set; }
        public string Email { get; set; } = null!;
        public int RecommendId { get; set; }
    }
}
