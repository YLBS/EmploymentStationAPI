using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ErmEmployeePosition
    {
        public int Id { get; set; }
        public int EplId { get; set; }
        public int DptId { get; set; }
        public int PosId { get; set; }
        public byte IsAdmin { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
