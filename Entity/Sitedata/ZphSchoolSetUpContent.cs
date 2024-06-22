using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphSchoolSetUpContent
    {
        public int Id { get; set; }
        public int SetUpId { get; set; }
        public int SetUpType { get; set; }
        public string SetUpContent { get; set; } = null!;
        public DateTime CreatDateTime { get; set; }
        public DateTime? UpDateTime { get; set; }
        public int ZphAdminId { get; set; }
        public bool IsDell { get; set; }
        public int Pid { get; set; }
    }
}
