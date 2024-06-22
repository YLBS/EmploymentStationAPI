using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemLibCommendVice
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int ViceId { get; set; }
        public int ReplId { get; set; }
        public DateTime AddTime { get; set; }
        public int IsSee { get; set; }
        public DateTime? SeeTime { get; set; }
        public int? PosId { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}
