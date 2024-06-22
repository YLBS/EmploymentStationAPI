using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class DicJobFunction
    {
        public int Id { get; set; }
        public int BigId { get; set; }
        public string Pname { get; set; } = null!;
        public string Ename { get; set; } = null!;
        public int OrderId { get; set; }
    }
}
