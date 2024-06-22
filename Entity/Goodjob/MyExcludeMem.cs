using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyExcludeMem
    {
        public int MyUserId { get; set; }
        public int MemId { get; set; }
        /// <summary>
        /// add date
        /// </summary>
        public DateTime? EDateTime { get; set; }
    }
}
