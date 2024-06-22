using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyIsRead
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
