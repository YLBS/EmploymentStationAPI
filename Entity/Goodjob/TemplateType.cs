using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class TemplateType
    {
        public int Id { get; set; }
        public string TemplateType1 { get; set; } = null!;
        public string TemplateTypeEn { get; set; } = null!;
        public string SiteType { get; set; } = null!;
        public int Dictionary { get; set; }
    }
}
