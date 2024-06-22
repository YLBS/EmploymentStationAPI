using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyMobileRecord
    {
        public int Id { get; set; }
        public string PhoneNum { get; set; } = null!;
        public int Type { get; set; }
        public DateTime RigisterDate { get; set; }
    }
}
