using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyPosSubscribe
    {
        public int MyUserId { get; set; }
        public string PosJobFunction { get; set; } = null!;
        public string PosJobLocation { get; set; } = null!;
        public int Style { get; set; }
        public bool Subscribe { get; set; }
    }
}
