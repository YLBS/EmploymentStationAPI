using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmLinkman
    {
        public int PosType { get; set; }
        public int SensType { get; set; }
        public int LnkId { get; set; }
        public int ComId { get; set; }
        public string LnkName { get; set; } = null!;
        public byte Sex { get; set; }
        public string DeptName { get; set; } = null!;
        public string PhoneN { get; set; } = null!;
        public string PhoneZ { get; set; } = null!;
        public string PhoneE { get; set; } = null!;
        public string FaxZ { get; set; } = null!;
        public string FaxN { get; set; } = null!;
        public string FaxE { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte IsAdmin { get; set; }
        public byte DelFlag { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Ctel { get; set; } = null!;
        public string SexText { get; set; } = null!;
        public string Cfax { get; set; } = null!;
        public string HrQq { get; set; } = null!;
        public string DeleteInfo { get; set; } = null!;
    }
}
