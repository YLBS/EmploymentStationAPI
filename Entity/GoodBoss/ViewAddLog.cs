using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewAddLog
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int EplId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string EplName { get; set; } = null!;
        public int DptId { get; set; }
    }
}
