using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysPageTemplate
    {
        public int PageId { get; set; }
        public string? Name { get; set; }
        public string? LeftInfo { get; set; }
        public string? RightInfo { get; set; }
        public int? MenuId { get; set; }
        public string? ModelName { get; set; }
        public string? TemplateInfo { get; set; }
        public DateTime? Intime { get; set; }
    }
}
