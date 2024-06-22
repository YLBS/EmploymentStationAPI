using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    /// <summary>
    /// 存储登记失业标签
    /// </summary>
    public partial class RegisterSign
    {
        public int Id { get; set; }

        public int MyUserId { get; set; }
        /// <summary>
        /// 1 失业人员 2 退伍军人
        /// </summary>
        public int Type { get; set; }
    }
}
