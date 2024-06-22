using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngCompleteQd
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public DateTime QdDate { get; set; }
        public int QdType { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string? Describe { get; set; }
    }
}
