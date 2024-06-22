using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmLinkman
    {
        public int LnkId { get; set; }
        public int ComId { get; set; }
        public string LnkName { get; set; } = null!;
        public byte Sex { get; set; }
        public string DeptName { get; set; } = null!;
        public int PosType { get; set; }
        public int SensType { get; set; }
        public string PhoneZ { get; set; } = null!;
        public string PhoneN { get; set; } = null!;
        public string PhoneE { get; set; } = null!;
        public string FaxZ { get; set; } = null!;
        public string FaxN { get; set; } = null!;
        public string FaxE { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte IsAdmin { get; set; }
        public byte DelFlag { get; set; }
        public DateTime RegisterDate { get; set; }
        public string? Comname { get; set; }
        public int? Eplid { get; set; }
        public string? Eplname { get; set; }
        public string HrQq { get; set; } = null!;
    }
}
