using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MyJobFunctionTime
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string JobTime { get; set; } = null!;
        public string WorkTime { get; set; } = null!;
        public DateTime CreatTime { get; set; }
        public string TimeType { get; set; } = null!;
    }
}
