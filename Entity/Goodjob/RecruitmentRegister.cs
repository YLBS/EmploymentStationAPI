using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class RecruitmentRegister
    {
        public int Id { get; set; }
        public string MemName { get; set; } = null!;
        public string PosName { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Esid { get; set; }
    }
}
