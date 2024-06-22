using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmDredgeCompany
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int MemId { get; set; }
        public string ComName { get; set; } = null!;
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DredgeDays { get; set; }
        public int DredgeType { get; set; }
        public int DredgeComType { get; set; }
        public int ApplyEplId { get; set; }
        public string ApplyEplName { get; set; } = null!;
        public string ApplyInfo { get; set; } = null!;
        public DateTime ApplyDate { get; set; }
        public int ExamEplId { get; set; }
        public string ExamEplName { get; set; } = null!;
        public string ExamInfo { get; set; } = null!;
        public DateTime? ExamDate { get; set; }
        public int CheckEplId { get; set; }
        public string CheckEplName { get; set; } = null!;
        public string CheckInfo { get; set; } = null!;
        public DateTime? CheckDate { get; set; }
        public int DredgeEplId { get; set; }
        public string DredgeEplName { get; set; } = null!;
        public string DredgeInfo { get; set; } = null!;
        public DateTime? DredgeDate { get; set; }
        /// <summary>
        /// 单状态 0 刚填写 1 审核不通过 2 审核通过 3 复核不通 4 复核通过
        /// </summary>
        public byte Status { get; set; }
        /// <summary>
        /// 开通状态 0未开通，1开通了
        /// </summary>
        public bool DredgeStatus { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
