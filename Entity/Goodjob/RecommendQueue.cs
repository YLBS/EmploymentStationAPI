using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class RecommendQueue
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        /// <summary>
        /// 企业对应业务员，个人无此项
        /// </summary>
        public string? SalerUserName { get; set; }
        /// <summary>
        /// 企业对应业务员号码，个人无此项
        /// </summary>
        public string? SalerTel { get; set; }
        public bool? EmaliFlag { get; set; }
        public string UserName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        /// <summary>
        /// 队列数据类型，1为企业，2为个人
        /// </summary>
        public int DataType { get; set; }
        public DateTime InsertTime { get; set; }
    }
}
