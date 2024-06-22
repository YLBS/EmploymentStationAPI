using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusAcompany
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string PassWord { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 0为填写 1 为填写
        /// </summary>
        public int IsFull { get; set; }
        public string ContactPhone { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string ComapnyDescribe { get; set; } = null!;
        public DateTime? UpDate { get; set; }
        public string FixedPhone { get; set; } = null!;
        /// <summary>
        /// 后台ID
        /// </summary>
        public int Crmcid { get; set; }
        /// <summary>
        /// 企业ID
        /// </summary>
        public int MemId { get; set; }
    }
}
