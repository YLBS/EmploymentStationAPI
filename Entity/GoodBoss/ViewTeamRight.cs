using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewTeamRight
    {
        public int TeamId { get; set; }
        public int MnuId { get; set; }
        public string TeamName { get; set; } = null!;
        public string MnuName { get; set; } = null!;
        public string? LnkUrl { get; set; }
        public bool IsBlank { get; set; }
        public int Id { get; set; }
    }
}
