using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemProductCatalog
    {
        public int CatalogId { get; set; }
        public string CatalogName { get; set; } = null!;
        public int MemId { get; set; }
        public bool IsDelete { get; set; }
    }
}
