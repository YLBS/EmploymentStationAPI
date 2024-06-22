using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemLibCommend
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public int MyUserId { get; set; }
        public byte MemFlag { get; set; }
        public DateTime InsertDate { get; set; }
        public int SalerId { get; set; }
        public int RecommendType { get; set; }
    }
}
