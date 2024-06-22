using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmDevelopStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public int CsId { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
