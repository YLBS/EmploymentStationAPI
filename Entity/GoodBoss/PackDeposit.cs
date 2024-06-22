using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PackDeposit
    {
        public int DepId { get; set; }
        public string? Number { get; set; }
        public string? Vouchers { get; set; }
        public int? Supplier { get; set; }
        public string? SupplierName { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public string? DptName { get; set; }
        public string? Remark { get; set; }
    }
}
