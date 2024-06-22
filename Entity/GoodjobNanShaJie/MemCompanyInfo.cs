using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MemCompanyInfo
    {
        public int MemId { get; set; }
        public string OrganizationName { get; set; } = null!;
        public string LicenseNumber { get; set; } = null!;
        public int Calling { get; set; }
        public int EmployeeNumber { get; set; }
        public string Introduce { get; set; } = null!;
        public int AddressP { get; set; }
        public int AddressC { get; set; }
        public int AddressT { get; set; }
        public string Address { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime? UpTime { get; set; }
        public DateTime RegisterTime { get; set; }
        public double CoordinateZ { get; set; }
        public double CoordinateY { get; set; }
        public string? Remarks { get; set; }
        /// <summary>
        /// 0 默认状态 1 审核通过 2 尚未审核通过  3提交审核
        /// </summary>
        public int? CompanyStats { get; set; }
    }
}
