using Entity.Goodjob;

namespace Models
{
    /// <summary>
    /// 失业登记DTO
    /// </summary>
    public class InputRegisterUnemploymentDto
    {
        public int EsId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; } = null!;
   
        //public string Email { get; set; } = "";
        public string PhoneNum { get; set; } = null!;
        /// <summary>
        /// 性别
        /// 1=男，2=女 
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public int Nationality { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        public int CardType { get; set; } = 0;
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CardNum { get; set; } = "";
        /// <summary>
        /// 身高
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// 体重
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// 婚姻状况
        /// 0=未婚，1=已婚，2=离异，3=保密
        /// </summary>
        public int MaritalStatus { get; set; }
        /// <summary>
        /// 户籍（省）
        /// </summary>
        public int HometownP { get; set; }
        /// <summary>
        /// 户籍（市）
        /// </summary>
        public int HometownC { get; set; }
        /// <summary>
        /// 现所在地（省）
        /// </summary>
        public int LocationP { get; set; }
        /// <summary>
        /// 现所在地（市）
        /// </summary>
        public int LocationC { get; set; }
        /// <summary>
        /// 学历
        /// 0=无，70=博士，60=硕士，50=本科，40=大专，30=中专，20=高中
        /// </summary>
        public int DegreeId { get; set; }
        /// <summary>
        /// 自我评价
        /// </summary>
        public string SelfDescription { get; set; } = "";
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string ZipCode { get; set; } = "";
        /// <summary>
        /// 曾工作的年份
        /// </summary>
        public int WorkedYear { get; set; }

        #region add
        /// <summary>
        /// 简历标题
        /// </summary>
        public string ResumeTitle { get; set; } = null!;
        /// <summary>
        /// 求职意向
        /// </summary>
        public List<MyJobFunctionModels> JobFunctionList { get; set; } = null!;
        /// <summary>
        /// 工作地区，市
        /// </summary>
        public int JobLocationP { get; set; }
        /// <summary>
        /// 工作地区，区
        /// </summary>
        public int JobLocationC { get; set; }
        /// <summary>
        /// 教育经历
        /// </summary>
        public string EduText { get; set; } = "";
        /// <summary>
        /// 工作经历
        /// </summary>
        public string WorkText { get; set; } = "";
        /// <summary>
        /// 登记标签，1 失业人员 2退伍军人
        /// </summary>
        public int RegisterType { get; set; }


        public string LastPosName { get; set; } = "";
        #endregion

    }
}
