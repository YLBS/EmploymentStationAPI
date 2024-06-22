using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmEplTask
    {
        public int Id { get; set; }
        public int? Syear { get; set; }
        public int? Smonth { get; set; }
        public int? Depid { get; set; }
        public int? Eplid { get; set; }
        public string? TaskValue { get; set; }
        public string? ComValue { get; set; }
    }
}
