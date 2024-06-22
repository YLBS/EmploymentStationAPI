using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmGetLog
    {
        public int Id { get; set; }
        public int? ComId { get; set; }
        public int? FEplId { get; set; }
        public int? TEplId { get; set; }
        public DateTime? GetDate { get; set; }
    }
}
