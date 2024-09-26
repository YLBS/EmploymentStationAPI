using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 添加企业DTO
    /// </summary>
    public partial class InputMemInfoJyDto
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; } = null!;

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; } = null!;

        /// <summary>
        /// 企业名称
        /// </summary>
        public string MemName { get; set; } = null!;

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; } = "";

        /// <summary>
        /// 邮箱是否公开
        /// </summary>
        public bool EmailShowFlag { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public int AddressP { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public int AddressC { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        public int AddressD { get; set; }

        /// <summary>
        /// 镇
        /// </summary>
        public int AddressT { get; set; }
        /// <summary>
        /// 通讯地址
        /// </summary>
        public string Address { get; set; } = null!;
        
        /// <summary>
        /// 所属行业
        /// </summary>
        public byte Calling { get; set; }

        /// <summary>
        /// 公司性质
        /// </summary>
        public byte Properity { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string ContactPerson { get; set; } = "";

        /// <summary>
        /// 联系人职务
        /// </summary>
        public string ContactDepartment { get; set; } = "";

        /// <summary>
        /// 固定电话 ContactTelZ - ContactTel - ContactTelE
        /// </summary>
        public string ContactTelZ { get; set; } = "";

        public string ContactTel { get; set; } = "";
        public string ContactTelE { get; set; } = "1";

        /// <summary>
        ///固定电话，是否公开电话
        /// </summary>
        public bool TelShowFlag { get; set; }

        public string Phone { get; set; } = "";
        public bool PhoneFlag { get; set; }

        /// <summary>
        /// 驿站Id 
        /// </summary>
        public int Esid { get; set; }
        
    }
}
