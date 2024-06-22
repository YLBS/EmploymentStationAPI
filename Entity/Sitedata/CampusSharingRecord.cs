using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusSharingRecord
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int CampusId { get; set; }
        public DateTime SartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int ResumeId { get; set; }
    }
}
