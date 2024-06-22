using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemWvideoApply
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string ContactPerson { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string Material { get; set; } = null!;
        public string PosIntoduction { get; set; } = null!;
        public string MemIntoduction { get; set; } = null!;
        public int CheckFlag { get; set; }
        public DateTime? CheckDate { get; set; }
        public string Rreason { get; set; } = null!;
        /// <summary>
        /// 1 zhong  2 wancheng
        /// </summary>
        public int MakeSate { get; set; }
    }
}
