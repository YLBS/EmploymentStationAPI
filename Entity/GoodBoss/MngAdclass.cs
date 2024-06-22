using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class MngAdclass
    {
        public int Id { get; set; }
        public string ClassCode { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public string ClassInfo { get; set; } = null!;
        public int Width { get; set; }
        public int Height { get; set; }
        public int Price { get; set; }
    }
}
