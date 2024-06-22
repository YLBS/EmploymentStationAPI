using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MyResume
    {
        public int MyUserId { get; set; }
        public string PerName { get; set; } = null!;
        public int Sex { get; set; }
        public int Age { get; set; }
        public int UserType { get; set; }
        public int Hight { get; set; }
        public double? CoordinateZ { get; set; }
        public double? CoordinateY { get; set; }
        public bool IsHealthy { get; set; }
        public DateTime? UpTime { get; set; }
        /// <summary>
        /// 简历状态默认0(0正常 1符合 2不符合
        /// </summary>
        public int ResumeSate { get; set; }
        public DateTime? ResumeTime { get; set; }
        public DateTime CreateTime { get; set; }
        public int AddressP { get; set; }
        public int AddressC { get; set; }
        public string Address { get; set; } = null!;
        /// <summary>
        /// 头像
        /// </summary>
        public string PhotoName { get; set; } = null!;
        /// <summary>
        /// 0 初始值 1公开 2为不公开
        /// </summary>
        public int PhotoDisplay { get; set; }
        /// <summary>
        /// 职位类型（13,11 ,号区分）
        /// </summary>
        public string? PosCalling { get; set; }
        public int SalaryType { get; set; }
        public string ContactPhone { get; set; } = null!;
        public string Email { get; set; } = null!;
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday { get; set; }
        public int JobAddressP { get; set; }
        public int JobAddressC { get; set; }
        public string JobAddress { get; set; } = null!;
    }
}
