using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemMapComplaint
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string ComplaintContent { get; set; } = null!;
        public string Ipaddress { get; set; } = null!;
        public DateTime AddDate { get; set; }
    }
}
