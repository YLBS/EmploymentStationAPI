using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class TemplateSet
    {
        public int Id { get; set; }
        public string TemplateSiteName { get; set; } = null!;
        public string TemplateType { get; set; } = null!;
        public string TemplateCoding { get; set; } = null!;
        public string TemplateFormat { get; set; } = null!;
        public string TemplateName { get; set; } = null!;
        public string TemplateConnten { get; set; } = null!;
    }
}
