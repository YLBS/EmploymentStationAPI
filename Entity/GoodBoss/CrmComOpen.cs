using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmComOpen
    {
        public int Id { get; set; }
        public byte OpenType { get; set; }
        public string Bondid { get; set; } = null!;
        public int ComId { get; set; }
        public int MemId { get; set; }
        public int PosNum { get; set; }
        public int ResumeNum { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Memo { get; set; } = null!;
        public DateTime CheckDate { get; set; }
        public byte CheckState { get; set; }
        public int CheckEplId { get; set; }
        public DateTime OpenDate { get; set; }
        public byte OpenState { get; set; }
        /// <summary>
        /// 0
        /// </summary>
        public int OpenEplId { get; set; }
        public DateTime InputDate { get; set; }
        public int InputEplId { get; set; }
        public int PartTimePositoin { get; set; }
        public int ReflashCount { get; set; }
    }
}
