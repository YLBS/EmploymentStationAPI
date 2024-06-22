using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class SArticleClass
    {
        public int Id { get; set; }
        public string ClassName { get; set; } = null!;
        public int ParentId { get; set; }
        public int SiteId { get; set; }
        public int OrderId { get; set; }
        public string FolderName { get; set; } = null!;
        public bool HasChild { get; set; }
    }
}
