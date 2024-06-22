using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class LogCommendResume
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public string MyUserId { get; set; } = null!;
        public int OnceCount { get; set; }
        public byte CommendType { get; set; }
        public DateTime CommendDate { get; set; }
    }
}
