using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyFulfil
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string BeginDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public string ComName { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
