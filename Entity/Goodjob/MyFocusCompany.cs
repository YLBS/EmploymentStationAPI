using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyFocusCompany
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; } = null!;
        public DateTime AddDate { get; set; }
    }
}
