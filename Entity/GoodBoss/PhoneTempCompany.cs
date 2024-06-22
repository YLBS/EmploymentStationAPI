using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PhoneTempCompany
    {
        public int Id { get; set; }
        public bool? IsEdit { get; set; }
        public int? Comid { get; set; }
        public string? Phone { get; set; }
        public string? RInfo { get; set; }
    }
}
