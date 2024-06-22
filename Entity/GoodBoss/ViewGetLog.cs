using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewGetLog
    {
        public int Id { get; set; }
        public int? ComId { get; set; }
        public DateTime? GetDate { get; set; }
        public int? EplId { get; set; }
        public int? DptId { get; set; }
        public int? TEplId { get; set; }
    }
}
