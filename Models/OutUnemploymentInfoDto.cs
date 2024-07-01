using Goodjob.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OutUnemploymentInfoDto
    {
        public int MyUserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; } = null!;
        /// <summary>
        /// 电子邮件地址
        /// </summary>
        public string Email { get; set; } = null!;
        public string PhoneNum { get; set; } = null!;
        /// <summary>
        /// 性别
        /// 1=男，2=女 
        /// </summary>
        public int Sex { get; set; }
        public string SexName
        {
            get
            {
                if (Sex == 1) return "男";
                return "女";
            }
        }
        /// <summary>
        /// 民族
        /// </summary>
        public int Nationality { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birthday.Year;
            }
        }
        /// <summary>
        /// 证件类型
        /// </summary>
        public int CardType { get; set; }
        
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CardNum { get; set; } = null!;
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

        public string MaritalStatusName
        {
            get
            {
                if (MaritalStatus == 0) return "未婚";
                if (MaritalStatus == 1) return "已婚";
                if (MaritalStatus == 2) return "离异";
                return "保密";
            }
        }

        /// <summary>
        /// 户籍（省）
        /// </summary>
        public int HometownP { get; set; }
        /// <summary>
        /// 户籍（市）
        /// </summary>
        public int HometownC { get; set; }
        public string HometownAddress
        {
            get
            {
                string cityName = NameProvider.GetCityName(HometownC);
                return NameProvider.GetProvinceName(HometownP) +
                       (string.IsNullOrEmpty(cityName) ? string.Empty : "-" + cityName);
            }
        }
        /// <summary>
        /// 现所在地（省）
        /// </summary>
        public int LocationP { get; set; }
        /// <summary>
        /// 现所在地（市）
        /// </summary>
        public int LocationC { get; set; }

        public string Location
        {
            get
            {
                string cityName = NameProvider.GetCityName(LocationC);
                return NameProvider.GetProvinceName(LocationP) +
                       (string.IsNullOrEmpty(cityName) ? string.Empty : "-" + cityName);
            }
        }
        /// <summary>
        /// 学历
        /// 0=无，70=博士，60=硕士，50=本科，40=大专，30=中专，20=高中
        /// </summary>
        public int DegreeId { get; set; }
        public string DegreeName
        {
            get
            {
                if (DegreeId == 20) return "高中";
                if (DegreeId == 30) return "中专";
                if (DegreeId == 40) return "大专";
                if (DegreeId == 50) return "本科";
                if (DegreeId == 60) return "硕士";
                if (DegreeId == 70) return "博士";
                return "无";
            }
        }
        /// <summary>
        /// 自我评价
        /// </summary>
        public string SelfDescription { get; set; } = null!;
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string ZipCode { get; set; } = null!;
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

        //public string JobLocatioAddress
        //{
        //    get
        //    {
        //        string cityName = NameProvider.GetCityName(JobLocationC);
        //        return NameProvider.GetProvinceName(JobLocationP) +
        //               (string.IsNullOrEmpty(cityName) ? string.Empty : "-" + cityName);
        //    }
        //}

        /// <summary>
        /// 教育经历
        /// </summary>
        public string EduText { get; set; } = null!;
        /// <summary>
        /// 工作经历
        /// </summary>
        public string WorkText { get; set; } = null!;
        /// <summary>
        /// 登记标签，1 失业人员 2退伍军人
        /// </summary>
        public int RegisterType { get; set; }


        public string LastPosName { get; set; } = null!;
        #endregion

    }
}
