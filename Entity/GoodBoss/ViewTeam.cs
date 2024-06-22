using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewTeam
    {
        public int Id { get; set; }
        public string TeamName { get; set; } = null!;
        public string? TeamMemo { get; set; }
    }
}
