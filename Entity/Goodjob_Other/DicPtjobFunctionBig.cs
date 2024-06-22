using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class DicPtjobFunctionBig
    {
        public int Id { get; set; }
        public string Pname { get; set; } = null!;
        public string Ename { get; set; } = null!;
        public int KeyId { get; set; }
        public int OrderId { get; set; }
    }
}
