using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmMandatory
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int EplId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int ShenheState { get; set; }
        public DateTime ShenheDateTime { get; set; }
        public string LiyouText { get; set; } = null!;
        public int State { get; set; }
    }
}
