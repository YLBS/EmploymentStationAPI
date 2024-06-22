using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class AdminUser
    {
        public int Id { get; set; }
        public string AdminName { get; set; } = null!;
        public string AdminPassword { get; set; } = null!;
        public string AdminClass { get; set; } = null!;
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
