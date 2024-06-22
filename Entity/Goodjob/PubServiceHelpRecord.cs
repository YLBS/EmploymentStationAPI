using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubServiceHelpRecord
    {
        public int Id { get; set; }
        public int Recordid { get; set; }
        public string Massage { get; set; } = null!;
        public int Memid { get; set; }
        public int Adminid { get; set; }
        public DateTime Createtime { get; set; }
    }
}
