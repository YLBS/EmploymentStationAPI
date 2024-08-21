using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OutPositionDto
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        public int MemId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        public string MemName { get; set; } = null!;
        /// <summary>
        /// 职位ID
        /// </summary>
        public int PosId { get; set; }
        public string PosName { get; set; } = null!;
        /// <summary>
        /// 职位性质 0 不限 1 全职 2兼职 3实习生 4 暑假工 5寒假工
        /// </summary>
        public byte PosType { get; set; }
        /// <summary>
        /// 招聘人数
        /// </summary>
        public int CandidatesNum { get; set; }

        public int Salary { get; set; }

        /// <summary>
        /// 最低月薪
        /// </summary>
        public int SalaryMin { get; set; }
        /// <summary>
        /// 最高月薪
        /// </summary>

        public int SalaryMax { get; set; }
        /// <summary>
        /// 默认12薪
        /// </summary>
        public int SalaryMonth { get; set; }
        public string SalaryRange { get; set; }
        public string SalaryStr
        {
            get
            {
                if (Salary == 0) return SalaryRange;
                return Goodjob.Common.NameProvider.GetSalaryName(Salary);
            }
        }

        

        /// <summary>
        /// 岗位描述
        /// </summary>
        public string Posdecription { get; set; } = null!;
        /// <summary>
        /// 性别
        /// </summary>
        public int ReqSex { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        public int ReqDegreeId { get; set; }
        /// <summary>
        /// 工作经验
        /// </summary>
        public int ReqWorkyear { get; set; }
        
        //public string JobLocationStr { get; set; } = null!;//工作地址

        /// <summary>
        /// 职位类别
        /// </summary>
        public List<MyJobFunctionModels> JobFunctionList { get; set; } = null!;
        /// <summary>
        /// 工作地址
        /// </summary>
        public List<JobLocationDto> JobLocation { get; set; } = null!;
        /// <summary>
        /// 面试地点
        /// </summary>
        public string ExamAddress { get; set; } = null!;
        /// <summary>
        /// 联系人
        /// </summary>
        public string ContactPerson { get; set; } = null!;
        /// <summary>
        /// 联系电话 ContactTelZ-ContactTel-ContactTelE
        /// </summary>
        public string ContactTelZ { get; set; } = null!;
        public string ContactTel { get; set; } = null!;
        public string ContactTelE { get; set; } = null!;

        public bool TelShowFlag { get; set; }
        /// <summary>
        /// 简历接收邮箱
        /// </summary>
        public string Email { get; set; } = null!;
        /// <summary>
        /// 邮件接收方式 0 简历中文，1 繁体中文，2 不接收
        /// </summary>
        public int EmailCodeFlag { get; set; }

        /// <summary>
        /// 手机电话
        /// </summary>
        public string? MobileNum { get; set; }
        /// <summary>
        /// 驿站Id
        /// </summary>
        public int EsId { get; set; }
        public byte PosState { get; set; }
        public string PosStateStr
        { 
            get{
                if (PosState == 2)
                {
                    return "发布中";

                }
                return "暂停发布";
            }
        }
        public string WelfaStr { get; set; }

        public int[] Welfa
        {
            get
            {
                if (!string.IsNullOrEmpty(WelfaStr))
                {
                    string[] s = WelfaStr.Split('|');
                    s = s.Where(o => !string.IsNullOrEmpty(o)).ToArray();
                    return Array.ConvertAll(s, int.Parse);
                }
                return new int[] { };
            }
        }
        public string PosLableStr { get; set; }

        public int[] PosLable
        {
            get
            {
                if (!string.IsNullOrEmpty(PosLableStr))
                {
                    string[] s = PosLableStr.Split(',');
                    s = s.Where(o => !string.IsNullOrEmpty(o)).ToArray();
                    return Array.ConvertAll(s, int.Parse);
                }
                return new int[]{};
            }
        }
    }
}
