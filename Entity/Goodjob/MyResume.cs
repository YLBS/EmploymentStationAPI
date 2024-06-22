using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyResume
    {
        /// <summary>
        /// 个人账号编号
        /// </summary>
        public int MyUserId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string PerName { get; set; } = null!;
        /// <summary>
        /// 性别
        /// 0=不限，1=男，2=女 （增加“不限”的目的是与其它表相应字段进行配合）
        /// </summary>
        public byte Sex { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public byte Nationality { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        public byte CardType { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CardNum { get; set; } = null!;
        /// <summary>
        /// 身高
        /// </summary>
        public short Height { get; set; }
        public short Weight { get; set; }
        /// <summary>
        /// 婚姻状况
        /// 0=未婚，1=已婚，2=离异，3=保密
        /// </summary>
        public byte MaritalStatus { get; set; }
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
        public byte DegreeId { get; set; }
        /// <summary>
        /// 自我评价
        /// </summary>
        public string SelfDescription { get; set; } = null!;
        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContactPhone { get; set; } = null!;
        /// <summary>
        /// 移动电话
        /// </summary>
        public string MobileNum { get; set; } = null!;
        /// <summary>
        /// 即时通讯号码
        /// </summary>
        public string Imnum { get; set; } = null!;
        /// <summary>
        /// 电子邮箱(和帐号表一样！要同步更新)
        /// </summary>
        public string Email { get; set; } = null!;
        /// <summary>
        /// 个人主页
        /// </summary>
        public string Homepage { get; set; } = null!;
        /// <summary>
        /// 通讯地址
        /// </summary>
        public string Address { get; set; } = null!;
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string ZipCode { get; set; } = null!;
        /// <summary>
        /// 职称
        /// </summary>
        public string PositionName { get; set; } = null!;
        /// <summary>
        /// 计算机能力
        /// </summary>
        public byte ComputerLevel { get; set; }
        /// <summary>
        /// 计算机技能描述
        /// </summary>
        public string ComputerSkills { get; set; } = null!;
        /// <summary>
        /// 其它技能
        /// </summary>
        public string OtherSkills { get; set; } = null!;
        /// <summary>
        /// 兴趣爱好(老系统无，新加、显示时注意为空就不显)
        /// </summary>
        public string Interesting { get; set; } = null!;
        /// <summary>
        /// 寻求职位描述(就是以前填写的三项加一起)
        /// </summary>
        public string JobSeeking { get; set; } = null!;
        /// <summary>
        /// 薪金要求
        /// </summary>
        public int Salary { get; set; }
        /// <summary>
        /// 食宿要求
        /// </summary>
        public string EatHouseNeeded { get; set; } = null!;
        /// <summary>
        /// 其它要求
        /// </summary>
        public string OtherNeeded { get; set; } = null!;
        /// <summary>
        /// 到职日期
        /// </summary>
        public byte CheckinDate { get; set; }
        /// <summary>
        /// 求职类型
        /// </summary>
        public byte JobType { get; set; }
        /// <summary>
        /// 发展方向
        /// </summary>
        public string CareerDirection { get; set; } = null!;
        /// <summary>
        /// 曾工作的年份
        /// </summary>
        public byte WorkedYear { get; set; }
        /// <summary>
        /// 曾工作的月份
        /// </summary>
        public byte WorkedMonth { get; set; }
        /// <summary>
        /// 肖像照片的名称
        /// </summary>
        public string PhotoName { get; set; } = null!;
        /// <summary>
        /// 照片显示
        /// 0不存在，1不显示，2显示
        /// </summary>
        public byte PhotoDisplay { get; set; }
        /// <summary>
        /// 注册日期（简历的注册日期，不同于帐号表中的）
        /// </summary>
        public DateTime RegisterDate { get; set; }
        /// <summary>
        /// 更新日期（同时更新帐号表中的更新日期）
        /// </summary>
        public DateTime UpdateDate { get; set; }
        /// <summary>
        /// 简历的状态
        /// 0=正常，1=隐藏简历，2=对指定的企业隐藏，3=待删除（独立功能操作）
        /// </summary>
        public byte ResumeStatus { get; set; }
        public string PartComName { get; set; } = null!;
        /// <summary>
        /// 诚信分
        /// </summary>
        public int AllCount { get; set; }
        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime? CheckDate { get; set; }
        /// <summary>
        /// 审核标志
        /// 1=待审核，2=审核通过，3=审核不通过，4=更新后待复审
        /// </summary>
        public byte CheckFlag { get; set; }
        /// <summary>
        /// 基本信息完整
        /// 0未填写，1已填写
        /// </summary>
        public byte BaseWrite { get; set; }
        /// <summary>
        /// 工作经验有填写
        /// 0未填写，1已填写
        /// </summary>
        public byte WorkWrite { get; set; }
        /// <summary>
        /// 教育经验有填写
        /// 0未填写，1已填写
        /// </summary>
        public byte EduWrite { get; set; }
        public byte TrainingWrite { get; set; }
        /// <summary>
        /// 语言有填写
        /// 0未填写，1已填写
        /// </summary>
        public byte LanguageWrite { get; set; }
        /// <summary>
        /// 意向填写完整
        /// 0未填写，1已填写
        /// </summary>
        public byte HopeWrite { get; set; }
        /// <summary>
        /// 项目有填写
        /// 0未填写，1已填写
        /// </summary>
        public byte ProjectWrite { get; set; }
        /// <summary>
        /// 证书有上传
        /// 0未填写，1已填写
        /// </summary>
        public byte CertWrite { get; set; }
        public byte FulfilWrite { get; set; }
        /// <summary>
        /// 技能专长完整
        /// </summary>
        public byte SkillWrite { get; set; }
        /// <summary>
        /// 整体完整性
        /// 0未填写完成，1基本完整，2很完整
        /// 基本完整：除项目、证书、肖像photodisplay、语言以外的都填写
        /// 很完整就要全部填写
        /// </summary>
        public byte AllWrite { get; set; }
        public int LocationT { get; set; }
        public bool IsdqStatus { get; set; }
        public int? VideoWrite { get; set; }
        public string Grade { get; set; } = null!;
        public string Professional { get; set; } = null!;
    }
}
