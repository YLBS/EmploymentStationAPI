using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngWeekly
    {
        public int Id { get; set; }
        public string MemId { get; set; } = null!;
        public DateTime WeeklyDate { get; set; }
        public string Title { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
