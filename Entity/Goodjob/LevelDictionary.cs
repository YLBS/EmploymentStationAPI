using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class LevelDictionary
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string SiteType { get; set; } = null!;
        public string MemName { get; set; } = null!;
        public string HtemplateType { get; set; } = null!;
        public string JtemplateType { get; set; } = null!;
        public string HomeName { get; set; } = null!;
        public string JobName { get; set; } = null!;
        public string Format { get; set; } = null!;
        public string Format1 { get; set; } = null!;
        public string? Coding { get; set; }
        public string? Coding1 { get; set; }
        public string? Joblocation { get; set; }
        public string Length { get; set; } = null!;
    }
}
