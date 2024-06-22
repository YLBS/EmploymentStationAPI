using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZhaoPinHuiAdminManage
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public int ZphAdminId { get; set; }
        public int SubZphAdminId { get; set; }
        public DateTime Createdate { get; set; }
    }
}
