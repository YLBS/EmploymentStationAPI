using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmOnduty
    {
        public int OnId { get; set; }
        public int? DptId { get; set; }
        public DateTime? OndutyDate { get; set; }
        public int Modtype { get; set; }
    }
}
