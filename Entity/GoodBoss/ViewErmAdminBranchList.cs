using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewErmAdminBranchList
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public DateTime? Regtime { get; set; }
        public string? ManaBranch { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public string? DptView { get; set; }
    }
}
