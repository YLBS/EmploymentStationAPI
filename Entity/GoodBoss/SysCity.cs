using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysCity
    {
        public int Cityid { get; set; }
        public int? Pid { get; set; }
        public string? CityName { get; set; }
        public int? OrderId { get; set; }
        public int IsShow { get; set; }
    }
}
