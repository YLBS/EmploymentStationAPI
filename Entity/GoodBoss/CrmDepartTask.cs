using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmDepartTask
    {
        public int Id { get; set; }
        public int? Syear { get; set; }
        public int? Smonth { get; set; }
        public int? Sugroup { get; set; }
        public string? TaskValue { get; set; }
        public string? ComValue { get; set; }
    }
}
