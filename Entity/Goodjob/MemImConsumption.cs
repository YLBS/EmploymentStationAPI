using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemImConsumption
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public DateTime Imdate { get; set; }
        public int Imcount { get; set; }
    }
}
