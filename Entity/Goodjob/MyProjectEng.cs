using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyProjectEng
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string BeginDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public string ProjectName { get; set; } = null!;
        public string ProjectMemo { get; set; } = null!;
        public string ProjectDuty { get; set; } = null!;
    }
}
