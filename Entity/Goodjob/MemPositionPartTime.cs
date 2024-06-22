using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemPositionPartTime
    {
        public int PosId { get; set; }
        public int MemId { get; set; }
        public string MemName { get; set; } = null!;
        public string PosName { get; set; } = null!;
        public byte Calling { get; set; }
        public int DeptId { get; set; }
        public int CandidatesNum { get; set; }
        public DateTime? EndValidDate { get; set; }
        public string Posdecription { get; set; } = null!;
        public int Salary { get; set; }
        /// <summary>
        /// 0 不限 1 全职 2兼职 3实习生 4 暑假工 5寒假工
        /// </summary>
        public byte PosType { get; set; }
        public int ReqDegreeId { get; set; }
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
        public byte EmailCodeFlag { get; set; }
        public int AddressP { get; set; }
        public int AddressC { get; set; }
        public string? Address { get; set; }
        public string ZipCode { get; set; } = null!;
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
        /// 薪资类型 1 固定薪资 2范围薪资
        /// </summary>
        public int SalaryMode { get; set; }
        /// <summary>
        ///  结算方式  1 日结  2 周结  3 月结  4 次结  5 计件结  6 完工结  7 面议
        /// </summary>
        public int SettlementMode { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        /// <summary>
        /// 薪资时间类型 1 元/每小时  2 元/每周  3元/每月
        /// </summary>
        public int SalryTimeType { get; set; }
        /// <summary>
        /// 薪资单位 1 元/每小时  2 元/每天  3 元/每周  4 元/每月  5 元/每次  6 元/每件
        /// </summary>
        public int SalaryUnit { get; set; }
        /// <summary>
        /// 提成类型  1 业绩提成  2 计件提成  3 自定义
        /// </summary>
        public int CommissionMode { get; set; }
        /// <summary>
        /// 提成百分比/提成金额/自定义提成
        /// </summary>
        public string Commission { get; set; } = null!;
        /// <summary>
        /// 工作种类  1 短招  2 长招
        /// </summary>
        public int WorkType { get; set; }
        /// <summary>
        ///  工作时间
        /// </summary>
        public string WorkDate { get; set; } = null!;
        /// <summary>
        /// 时间要求 能工作1-6个月以上  数值 1-6
        /// </summary>
        public int MonthRequired { get; set; }
        /// <summary>
        /// 每周至少工作1-7天  数值 1-7
        /// </summary>
        public int WeekRequired { get; set; }
        /// <summary>
        /// 身高
        /// </summary>
        public string Height { get; set; } = null!;
        /// <summary>
        /// 上班时段
        /// </summary>
        public string WorkTime { get; set; } = null!;
        public DateTime ResulatDate { get; set; }
        public int JobFunctionBig { get; set; }
        public int JobFunctionSmall { get; set; }
        public string JobLocationP { get; set; } = null!;
        public string JobLocationC { get; set; } = null!;
    }
}
