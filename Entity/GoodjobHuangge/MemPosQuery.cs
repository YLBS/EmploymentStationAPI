using System;
using System.Collections.Generic;

namespace Entity.GoodjobHuangge
{
    public partial class MemPosQuery
    {
        public int PosId { get; set; }
        public int MemId { get; set; }
        public string MemName { get; set; } = null!;
        public string PosName { get; set; } = null!;
        public DateTime PostDate { get; set; }
        public byte Calling { get; set; }
        public int DeptId { get; set; }
        public int CandidateNum { get; set; }
        public byte Salary { get; set; }
        public byte PosType { get; set; }
        public int ReqDegreeId { get; set; }
        public byte ReqWorkYear { get; set; }
        public byte ReqSex { get; set; }
        public byte ReqAge1 { get; set; }
        public byte ReqAge2 { get; set; }
        public string PosDescription { get; set; } = null!;
        public string JobLocation { get; set; } = null!;
        /// <summary>
        /// 是否推荐企业
        /// </summary>
        public bool Iscommend { get; set; }
        /// <summary>
        /// 是否有专页
        /// </summary>
        public bool HasPage { get; set; }
        public bool Geyn { get; set; }
        public int? MemLocation { get; set; }
        public DateTime? MemRegisterDate { get; set; }
        public byte? Properity { get; set; }
        public string SeoAddress { get; set; } = null!;
        public bool Hires { get; set; }
        public string? Welfa { get; set; }
        public string? SalaryRange { get; set; }
        public double Lng { get; set; }
        public double Lat { get; set; }
    }
}
