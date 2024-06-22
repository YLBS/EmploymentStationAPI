using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphMyEntrance
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public int MyUserId { get; set; }
        public DateTime EntranceDate { get; set; }
    }
}
