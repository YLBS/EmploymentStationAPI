using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmAbnegateGiveUp
    {
        public int Id { get; set; }
        public int DptId { get; set; }
        public int GiveUpCount { get; set; }
        public DateTime GiveUpDate { get; set; }
        public int AngTypeCsId { get; set; }
    }
}
