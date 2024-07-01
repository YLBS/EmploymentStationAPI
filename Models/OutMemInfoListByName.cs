using Goodjob.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OutMemInfoListByName
    {
        public int MemId { get; set; }
        public string MemName { get; set; } = null!;
        public DateTime FoundDate { get; set; }

        public string FoundDateStr {
            get
            {
                return FoundDate.ToString("YYYY-MM-DD");
            }
        }
        public int AddressP { get; set; }
        public int AddressC { get; set; }

        public string AddressName
        {
            get
            {
                return NameProvider.GetProvinceName(AddressP) + NameProvider.GetCityName(AddressC);
            }
        }

        public string Address { get; set; } = null!;
        public DateTime RegisterDate { get; set; }

        public string RegisterDateStr
        {
            get { return RegisterDate.ToString("YYYY-MM-DD"); }
        }
        public string Phone { get; set; } = null!;
    }
}
