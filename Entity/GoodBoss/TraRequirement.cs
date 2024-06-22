using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class TraRequirement
    {
        /// <summary>
        /// 编号
        /// </summary>
        public Guid CourseId { get; set; }
        /// <summary>
        /// 所属人
        /// </summary>
        public int? EplId { get; set; }
        /// <summary>
        /// 所属姓名
        /// </summary>
        public string? EplName { get; set; }
        /// <summary>
        /// 所在部门
        /// </summary>
        public int? DptId { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string? DptName { get; set; }
        /// <summary>
        /// 需求课程名称
        /// </summary>
        public string? CourseName { get; set; }
        /// <summary>
        /// 培训内容
        /// </summary>
        public string? TraineText { get; set; }
        /// <summary>
        /// 培训对象
        /// </summary>
        public string? TrainedObject { get; set; }
        /// <summary>
        /// 培训形式
        /// </summary>
        public string? TrainedForm { get; set; }
        /// <summary>
        /// 培训机构推荐
        /// </summary>
        public string? RecommendAgency { get; set; }
        /// <summary>
        /// 培训预算
        /// </summary>
        public decimal? TrainBudget { get; set; }
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime? ArrangeTime { get; set; }
        /// <summary>
        /// 培训目的
        /// </summary>
        public string? TrainObjective { get; set; }
        /// <summary>
        /// 师资要求
        /// </summary>
        public decimal? FundingRequirement { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public short? State { get; set; }
        /// <summary>
        /// 需培训时间
        /// </summary>
        public DateTime? Calltime { get; set; }
        /// <summary>
        /// 效果考核
        /// </summary>
        public string? ResultText { get; set; }
        /// <summary>
        /// 需求编号
        /// </summary>
        public string? CourseNumber { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public int? CheckeplId { get; set; }
        /// <summary>
        /// 审核人姓名
        /// </summary>
        public string? CheckEplName { get; set; }
        /// <summary>
        /// 审核备注
        /// </summary>
        public string? CheckRemark { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? CheckTime { get; set; }
    }
}
