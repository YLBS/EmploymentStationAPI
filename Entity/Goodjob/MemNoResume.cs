using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemNoResume
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
