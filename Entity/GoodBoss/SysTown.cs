using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysTown
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Pname { get; set; } = null!;
        public string Ename { get; set; } = null!;
        public int OrderId { get; set; }
        public bool? IsShow { get; set; }
    }
}
