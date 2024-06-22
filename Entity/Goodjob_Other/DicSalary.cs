using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class DicSalary
    {
        public int Id { get; set; }
        public string Pname { get; set; } = null!;
        public string Ename { get; set; } = null!;
        public int OrderId { get; set; }
        public string Name { get; set; } = null!;
    }
}
