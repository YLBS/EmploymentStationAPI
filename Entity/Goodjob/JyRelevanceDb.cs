using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class JyRelevanceDb
    {
        public int Id { get; set; }
        public string DbName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int BelongType { get; set; }
        public bool IsDelete { get; set; }
    }
}
