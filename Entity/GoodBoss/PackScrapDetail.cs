using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PackScrapDetail
    {
        public int UdId { get; set; }
        public int? ScrId { get; set; }
        public int? ArtId { get; set; }
        public string? ArtName { get; set; }
        public string? Units { get; set; }
        public string? Specification { get; set; }
        public decimal? Pricing { get; set; }
        public int? Number { get; set; }
        public decimal? Price { get; set; }
        public string? Remark { get; set; }
        public DateTime? Intime { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public short? State { get; set; }
    }
}
