using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemLibOwer
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public int MyUserId { get; set; }
        public int MemLibSort { get; set; }
        public byte MemFlag { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
