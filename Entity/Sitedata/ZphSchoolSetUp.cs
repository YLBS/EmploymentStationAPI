using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphSchoolSetUp
    {
        public int Id { get; set; }
        /// <summary>
        /// 0 初始值 1年级  2院系 3专业 4班级
        /// </summary>
        public int Stype { get; set; }
        public DateTime UpDateTime { get; set; }
        public bool IsEnable { get; set; }
        public int ZphAdminId { get; set; }
        public int Pid { get; set; }
    }
}
