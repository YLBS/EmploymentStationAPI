using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class SysSalerDownload
    {
        public int Id { get; set; }
        public int? MyUserId { get; set; }
        public int? SalerId { get; set; }
        public DateTime BrowseTime { get; set; }
    }
}
