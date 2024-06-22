using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmProcessClient
    {
        public int Id { get; set; }
        public int? ComId { get; set; }
        public string? ComName { get; set; }
        public short State { get; set; }
        public short? Type { get; set; }
        public int? Retainday { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public string? Remark { get; set; }
        public DateTime? Intime { get; set; }
    }
}
