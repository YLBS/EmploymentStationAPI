using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmRecord
    {
        public int RId { get; set; }
        public int? CId { get; set; }
        public DateTime? RDate { get; set; }
        public int? RType { get; set; }
        public string? RContent { get; set; }
        public int? Author { get; set; }
        public string? Bgcolor { get; set; }
        public string? TypeName { get; set; }
        public string? EplName { get; set; }
        public string? ComName { get; set; }
        public int? Len { get; set; }
        /// <summary>
        /// 0
        /// </summary>
        public int? DptId { get; set; }
        public string? Wavname { get; set; }
    }
}
