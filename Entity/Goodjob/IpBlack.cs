using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class IpBlack
    {
        public int Id { get; set; }
        public string Ipaddress { get; set; } = null!;
        public DateTime IpaddDate { get; set; }
    }
}
