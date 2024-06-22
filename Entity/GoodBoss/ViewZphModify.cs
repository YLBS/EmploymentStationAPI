using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewZphModify
    {
        public int ModifyId { get; set; }
        public string ComName { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public string ModifyComName { get; set; } = null!;
        public string ModifyContact { get; set; } = null!;
        public string ModifyMobile { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string ComName1 { get; set; } = null!;
        public int ComId { get; set; }
        public int Audit { get; set; }
        public int SignId { get; set; }
    }
}
