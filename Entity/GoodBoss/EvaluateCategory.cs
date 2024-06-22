using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class EvaluateCategory
    {
        public Guid Id { get; set; }
        public int? CateId { get; set; }
        public string? CateName { get; set; }
        public string? Remark { get; set; }
    }
}
