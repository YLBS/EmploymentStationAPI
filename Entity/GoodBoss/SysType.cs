using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysType
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string? TypeName { get; set; }
        public string? Alias { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
