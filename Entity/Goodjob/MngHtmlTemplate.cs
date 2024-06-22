using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngHtmlTemplate
    {
        public int Id { get; set; }
        public string TemplateName { get; set; } = null!;
        public string TemplatePath { get; set; } = null!;
        public string MasterPagePath { get; set; } = null!;
        public byte SaveFilePathType { get; set; }
        public string SaveFilePath { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Keyword { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte CreateType { get; set; }
        public bool Disabled { get; set; }
        public DateTime AddTime { get; set; }
        public int TemplateType { get; set; }
        public string SaveEncoding { get; set; } = null!;
    }
}
