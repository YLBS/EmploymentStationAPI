using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphAdminUser
    {
        public int ZphAdminId { get; set; }
        public string Title { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsUse { get; set; }
        public int SuperiorAdminId { get; set; }
        public string AffiliatedUnit { get; set; } = null!;
    }
}
