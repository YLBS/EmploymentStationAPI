using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysDegree
    {
        public int Id { get; set; }
        public int DgrId { get; set; }
        public string? DgrName { get; set; }
        public string? Alias { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
