using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemSmsRecord
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserid { get; set; }
        public string Phone { get; set; } = null!;
        public string SendContent { get; set; } = null!;
        public DateTime SendTime { get; set; }
        public int PosId { get; set; }
        /// <summary>
        /// 上行返回短信
        /// </summary>
        public string BackContent { get; set; } = null!;
        /// <summary>
        /// 0 无回复； 1 有回复 ； 2 有回复已查看
        /// </summary>
        public int Backstatus { get; set; }
    }
}
