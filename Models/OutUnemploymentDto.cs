using Goodjob.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OutUnemploymentDto
    {
        public int MyUserId { get; set; }
        
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; } = null!;
        /// <summary>
        /// 性别
        /// 0=不限，1=男，2=女 （增加“不限”的目的是与其它表相应字段进行配合）
        /// </summary>
        public byte Sex { get; set; }

        public string SexName
        {
            get
            {
                if (Sex == 1) return "男";
                return "女";
            }
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday { get; set; }
        public int Age {
            get
            {
                return DateTime.Now.Year - Birthday.Year;
            }
        }
        /// <summary>
        /// 学历
        /// 0=无，70=博士，60=硕士，50=本科，40=大专，30=中专，20=高中
        /// </summary>
        public byte DegreeId { get; set; }

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
        /// 曾工作的年份
        /// </summary>
        public byte WorkedYear { get; set; }
        /// <summary>
        /// 登记类型 1 失业人员 ，其余为退伍军人
        /// </summary>
        public int RegisterType { get; set; }

        public string RegisterTypeName {
            get
            {
                if (RegisterType == 1) return "失业人员";
                return "退伍军人";
            }
        }
        /// <summary>
        /// 审核标志
        /// 1=待审核，2=审核通过，3=审核不通过，4=更新后待复审
        /// </summary>
        public byte CheckFlag { get; set; }
        public string CheckFlagName {
            get
            {
                if (CheckFlag == 1) return "待审核";
                if (CheckFlag == 2) return "审核通过";
                if (CheckFlag == 3) return "审核不通过";
                return "更新后待复审";
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
        public int BelongType { get; set; }
        public string BelongName {
            get
            {
                if (BelongType == 1) return "大岗";
                if (BelongType == 2) return "南沙";
                return "黄阁";//4

            }
        }
    }
}
