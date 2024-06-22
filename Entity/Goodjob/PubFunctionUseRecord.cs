using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubFunctionUseRecord
    {
        public int Id { get; set; }
        public string FunctionName { get; set; } = null!;
        public int FunctionType { get; set; }
        public DateTime CreateDate { get; set; }
        public int Fcount { get; set; }
    }
}
