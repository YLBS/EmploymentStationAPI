using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class SysRegisterFrom
    {
        public int MyUserId { get; set; }
        /// <summary>
        /// 1.赶集,2.58,3.51job,4.南方/番禺人才网,5.智联招聘,6.门店,7.现场招聘,8.黄阁镇人社局,9.达内教育培训(省人才),10大岗人才后台管理 11黄阁人才后台管理  12 boss,13 智联 14 前程 17南沙驿站 18南村人才网  100.其他,
        /// </summary>
        public int RegisterFrom { get; set; }
        public DateTime RegisterFromDate { get; set; }
    }
}
