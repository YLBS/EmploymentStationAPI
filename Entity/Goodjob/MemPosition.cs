using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemPosition
    {
        public int PosId { get; set; }
        public int MemId { get; set; }
        public string MemName { get; set; } = null!;
        public string PosName { get; set; } = null!;
        public string TagLib { get; set; } = null!;
        public byte Calling { get; set; }
        public int DeptId { get; set; }
        public int CandidatesNum { get; set; }
        public DateTime? EndValidDate { get; set; }
        public string Posdecription { get; set; } = null!;
        public byte Salary { get; set; }
        /// <summary>
        /// 0 不限 1 全职 2兼职 3实习生 4 暑假工 5寒假工
        /// </summary>
        public byte PosType { get; set; }
        public int ReqDegreeId { get; set; }
        public byte ReqWorkyear { get; set; }
        public byte ReqMarital { get; set; }
        public int RegHometownP { get; set; }
        public int RegHometownC { get; set; }
        public byte ReqSex { get; set; }
        public byte ReqAge1 { get; set; }
        public byte ReqAge2 { get; set; }
        public string JobLocation { get; set; } = null!;
        public string ExamNotice { get; set; } = null!;
        public string ExamAddress { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string ContactTelZ { get; set; } = null!;
        public string ContactTel { get; set; } = null!;
        public string ContactTelE { get; set; } = null!;
        public bool TelShowFlag { get; set; }
        public string ContactFaxZ { get; set; } = null!;
        public string ContactFax { get; set; } = null!;
        public string ContactFaxE { get; set; } = null!;
        public bool FaxShowFlag { get; set; }
        public string Email { get; set; } = null!;
        public bool EmailShowFlag { get; set; }
        /// <summary>
        /// 0简体中文；1繁体中文；2不接收
        /// </summary>
        public byte EmailCodeFlag { get; set; }
        public int AddressP { get; set; }
        public int AddressC { get; set; }
        public string? Address { get; set; }
        public string ZipCode { get; set; } = null!;
        /// <summary>
        /// 0 暂停 1 已过期 2 发布中
        /// </summary>
        public byte PosState { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime PostDate { get; set; }
        public int HitCounter { get; set; }
        public bool Geyn { get; set; }
        public byte UpdateFlag { get; set; }
        public bool Hires { get; set; }
        public DateTime BeginHiresDate { get; set; }
        public string? Welfa { get; set; }
        public string? SalaryRange { get; set; }
        public string MobileNum { get; set; } = null!;
        public string JobFunctionPart { get; set; } = null!;
        /// <summary>
        /// 转正机会  1 提供转正  2 不提供转正  3 面议
        /// </summary>
        public int RegularWorker { get; set; }
        public int Months { get; set; }
        /// <summary>
        /// 0 薪资类型 1 固定薪资 2范围薪资
        /// </summary>
        public int SalaryMode { get; set; }
        /// <summary>
        /// 固定薪资 用于存放 千元等 用户手动输入的金额
        /// </summary>
        public int PosSalary { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        /// <summary>
        /// 薪资单位 1 元/每小时  2 元/每天  3 元/每周  4 元/每月  5 元/每次  6 元/每件
        /// </summary>
        public int SalaryUnit { get; set; }
        /// <summary>
        /// 0
        /// </summary>
        public int WeekRequired { get; set; }
        /// <summary>
        /// 0 俊才 1.前程 2.boss 3.58 4.智联 5拉钩
        /// </summary>
        public int? RegisterBy { get; set; }
        /// <summary>
        /// 默认12薪
        /// </summary>
        public int SalaryMonth { get; set; }
    }
}
