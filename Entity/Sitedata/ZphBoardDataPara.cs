using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphBoardDataPara
    {
        public int Id { get; set; }
        public bool SignUpMemFlag { get; set; }
        public bool EntryMemFlag { get; set; }
        public bool RecruitPosFlag { get; set; }
        public bool RequirePosFlag { get; set; }
        public bool RecruitPerFlag { get; set; }
        public bool SignUpPerFlag { get; set; }
        public bool EntryPerFlag { get; set; }
        public bool EntryPerNameFlag { get; set; }
        public int EntryPerNameRadio { get; set; }
        public bool InviteFlag { get; set; }
        public bool ApplyFlag { get; set; }
        public bool InterviewFlag { get; set; }
        public int EntryMemInterval { get; set; }
        public int EntryMemIncrease { get; set; }
        public int EntryMemMaxCount { get; set; }
        public int EntryPerInterval { get; set; }
        public int EntryPerIncrease { get; set; }
        public int EntryPerMaxCount { get; set; }
        public int InviteInterval { get; set; }
        public int InviteIncrease { get; set; }
        public int InviteMaxCount { get; set; }
        public int ApplyInterval { get; set; }
        public int ApplyIncrease { get; set; }
        public int ApplyMaxCount { get; set; }
        public int InterviewInterval { get; set; }
        public int InterviewIncrease { get; set; }
        public int InterviewMaxCount { get; set; }
        public int PId { get; set; }
        /// <summary>
        /// 报名企业数
        /// </summary>
        public int SignUpMemCount { get; set; }
        /// <summary>
        /// 入场企业数
        /// </summary>
        public int EntryMemCount { get; set; }
        /// <summary>
        /// 招聘岗位数
        /// </summary>
        public int RecruitPosCount { get; set; }
        /// <summary>
        /// 需求岗位数
        /// </summary>
        public int RequirePosCount { get; set; }
        /// <summary>
        /// 招聘人数
        /// </summary>
        public int RecruitPerCount { get; set; }
        /// <summary>
        /// 报名学生数
        /// </summary>
        public int SignUpPerCount { get; set; }
        /// <summary>
        /// 现场入场人数
        /// </summary>
        public int EntryPerCount { get; set; }
        /// <summary>
        /// 企业邀请数
        /// </summary>
        public int InviteCount { get; set; }
        /// <summary>
        /// 学生预约数
        /// </summary>
        public int ApplyCount { get; set; }
        /// <summary>
        /// 实时面试数
        /// </summary>
        public int InterviewCount { get; set; }
        public int Switch { get; set; }
        public bool MajorFlag { get; set; }
        public bool CompareFlag { get; set; }
        public bool SalaryFlag { get; set; }
    }
}
