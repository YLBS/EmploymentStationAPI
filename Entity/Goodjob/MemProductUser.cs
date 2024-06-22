using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemProductUser
    {
        public int MemId { get; set; }
        public byte RoleFlag { get; set; }
        public int MaxProductNum { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime OpenDate { get; set; }
    }
}
