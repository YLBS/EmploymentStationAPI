using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class QyServeRemindRecord
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public string WeiXinHao { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
