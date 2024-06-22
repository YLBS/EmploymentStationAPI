using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PackUseDetail
    {
        public int UdId { get; set; }
        public int? DepId { get; set; }
        public int? ArtId { get; set; }
        public string? ArtName { get; set; }
        public string? Units { get; set; }
        public string? Specification { get; set; }
        public decimal? Pricing { get; set; }
        public int? Number { get; set; }
        public decimal? Price { get; set; }
        public string? Remark { get; set; }
        public short? State { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public DateTime? Intime { get; set; }
        public int? OldUdId { get; set; }
        public int? AlterEplId { get; set; }
        public string? AlterEplName { get; set; }
        public DateTime? AlterTime { get; set; }
        public DateTime? RecoverTime { get; set; }
        public DateTime? DeposeTime { get; set; }
    }
}
