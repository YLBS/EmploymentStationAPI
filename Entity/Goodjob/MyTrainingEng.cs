using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyTrainingEng
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string BeginDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public string Organization { get; set; } = null!;
        public string Course { get; set; } = null!;
        public string Certificate { get; set; } = null!;
        public string EduMemo { get; set; } = null!;
    }
}
