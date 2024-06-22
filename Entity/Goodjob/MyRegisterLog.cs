using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyRegisterLog
    {
        public int Id { get; set; }
        public string? Parameter { get; set; }
        public string? Myuserid { get; set; }
        public string? Belongtype { get; set; }
        public string? Registerfrom { get; set; }
        public DateTime Createtime { get; set; }
    }
}
