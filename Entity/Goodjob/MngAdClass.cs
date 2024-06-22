using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngAdClass
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
