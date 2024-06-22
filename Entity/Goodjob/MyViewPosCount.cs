using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyViewPosCount
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public DateTime ViewDate { get; set; }
        public int ViewCount { get; set; }
        public int PosType { get; set; }
    }
}
