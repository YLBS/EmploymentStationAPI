

using Goodjob.Common;

namespace Models
{
    public class OutMemInfoDto
    {

        public int MemId { get; set; }
        public string MemName { get; set; } = null!;
        public int AddressP { get; set; }
        public int AddressC { get; set; }
        public string AddressName
        {
            get { return NameProvider.GetProvinceName(AddressP) + "-" + NameProvider.GetCityName(AddressC); }
        }
        /// <summary>
        /// 联系人
        /// </summary>
        public string ContactPerson { get; set; } = null!;
        public string Phone { get; set; } = null!;
        /// <summary>
        /// 职位数
        /// </summary>
        public int PosNum { get; set; }
        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime RegisterDate { get; set; }
        
        public string Address { get; set; } = null!;
        
    }
}
