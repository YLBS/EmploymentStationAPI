using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusMackeRomvePo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CampusZpId { get; set; }
        public string PosName { get; set; } = null!;
        public DateTime UpTime { get; set; }
    }
}
