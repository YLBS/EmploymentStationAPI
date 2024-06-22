using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysEmpState
    {
        public int Id { get; set; }
        public int EsId { get; set; }
        public string? EsName { get; set; }
        public string? Alias { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
