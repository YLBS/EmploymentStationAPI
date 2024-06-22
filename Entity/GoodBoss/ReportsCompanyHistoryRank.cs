using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ReportsCompanyHistoryRank
    {
        public int Id { get; set; }
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public string? Picture { get; set; }
        public int? Receivemoney { get; set; }
        public string? DptName { get; set; }
        public DateTime? Intime { get; set; }
    }
}
