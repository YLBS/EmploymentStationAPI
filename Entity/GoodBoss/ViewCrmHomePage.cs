using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmHomePage
    {
        public int CheckState { get; set; }
        public DateTime OnlineDate { get; set; }
        public DateTime AddTime { get; set; }
        public int AdTypeId { get; set; }
        public string DemoText { get; set; } = null!;
        public int EplId { get; set; }
        public int MemId { get; set; }
        public int ComId { get; set; }
        public int Id { get; set; }
        public string ComName { get; set; } = null!;
        public string EplName { get; set; } = null!;
    }
}
