using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewZphSign
    {
        public int ZhaoPinHuiId { get; set; }
        public int Expr1 { get; set; }
        public string Title { get; set; } = null!;
        public string ComName { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public int Audit { get; set; }
        public int Number { get; set; }
        public int SignId { get; set; }
        public int ComId { get; set; }
        public string ComName1 { get; set; } = null!;
        public int EplId { get; set; }
        public int? Modify { get; set; }
        public int ModifyCount { get; set; }
        public bool NumberOk { get; set; }
        public string? ProName { get; set; }
        public string ModifyText { get; set; } = null!;
        public int ProEplId { get; set; }
    }
}
