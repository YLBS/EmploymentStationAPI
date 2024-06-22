using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyRegisterForCrm
    {
        public int MyUserId { get; set; }
        public DateTime RegisterDate { get; set; }
        public int EplId { get; set; }
        public string ExtranetId { get; set; } = null!;
        public string VisitDescrption { get; set; } = null!;
        public byte IsServer { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
