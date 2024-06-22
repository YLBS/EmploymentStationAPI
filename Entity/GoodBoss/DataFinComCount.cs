using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class DataFinComCount
    {
        public int Id { get; set; }
        public int Syear { get; set; }
        public int Smonth { get; set; }
        public string Sname { get; set; } = null!;
        public int Svalue { get; set; }
    }
}
