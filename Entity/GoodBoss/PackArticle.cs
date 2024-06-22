using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PackArticle
    {
        public int ArtId { get; set; }
        public string? ArtName { get; set; }
        public string? Specification { get; set; }
        public int? BigType { get; set; }
        public int? PackType { get; set; }
        public string? PackTypeName { get; set; }
        public string? Origin { get; set; }
        public decimal? Price { get; set; }
        public string? Depiction { get; set; }
        public string? Picture { get; set; }
        public int? Inventory { get; set; }
        public int? Userof { get; set; }
        public int? Scrap { get; set; }
        public DateTime? InTime { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? Allsum { get; set; }
    }
}
