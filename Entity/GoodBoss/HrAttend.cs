using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class HrAttend
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public string Attenddate { get; set; } = null!;
        public int DateWeek { get; set; }
        public string Morningtime { get; set; } = null!;
        public string Morningbz { get; set; } = null!;
        public int Morningcount { get; set; }
        public string Afternoontime { get; set; } = null!;
        public string Afternoonbz { get; set; } = null!;
        public int Afternooncount { get; set; }
    }
}
