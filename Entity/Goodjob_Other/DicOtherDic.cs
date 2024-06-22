using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class DicOtherDic
    {
        public int Id { get; set; }
        public int DicId { get; set; }
        public string Pname { get; set; } = null!;
        public string Ename { get; set; } = null!;
        public int OrderId { get; set; }
        public int DicType { get; set; }
        public string TypeMemo { get; set; } = null!;
    }
}
