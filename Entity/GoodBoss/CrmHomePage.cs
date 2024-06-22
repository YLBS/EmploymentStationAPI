using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmHomePage
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int MemId { get; set; }
        public int EplId { get; set; }
        public string DemoText { get; set; } = null!;
        public int AdTypeId { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime OnlineDate { get; set; }
        public int CheckState { get; set; }
    }
}
