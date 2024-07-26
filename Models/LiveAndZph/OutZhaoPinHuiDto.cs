using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LiveAndZph
{
    public class OutZhaoPinHuiDto
    {
        public int Pid { get; set; }
        public string Title { get; set; } = null!;
        public DateTime BenigDate { get; set; }
        public DateTime EndDate { get; set; }
        
        /// <summary>
        /// 协办方
        /// </summary>
        public string AssistHostunit { get; set; } = null!;
        /// <summary>
        /// 承办方
        /// </summary>
        public string UndertakeHostunit { get; set; } = null!;
        /// <summary>
        /// 备注 简介 说明
        /// </summary>
        public string Remark { get; set; } = null!;
        /// <summary>
        /// 招聘会二维码群名
        /// </summary>
        public string ZphGroupName { get; set; } = null!;
        /// <summary>
        /// 学生操作手册路径
        /// </summary>
        public string StudentInstructionsPath { get; set; } = null!;
        /// <summary>
        /// 企业操作手册路径
        /// </summary>
        public string MemInstructionsPath { get; set; } = null!;
        /// <summary>
        /// 驿站ID
        /// </summary>
        public int Esid { get; set; }
    }
}
