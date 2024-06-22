using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemJcb
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int Jcbcount { get; set; }
        public DateTime AddTime { get; set; }
        public int SalerId { get; set; }
        /// <summary>
        /// --0 新增 1支出 2系统退回 
        /// </summary>
        public int Jtype { get; set; }
    }
}
