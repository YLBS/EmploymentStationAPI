using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class IpBlackRecord
    {
        public int Id { get; set; }
        public string Ipaddress { get; set; } = null!;
        public DateTime RecordDate { get; set; }
        public int? RecordCount { get; set; }
    }
}
