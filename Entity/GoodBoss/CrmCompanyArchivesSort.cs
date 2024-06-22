using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmCompanyArchivesSort
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public DateTime RegisterDate { get; set; }
    }
}
