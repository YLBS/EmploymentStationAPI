using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngLiveShare
    {
        public int Id { get; set; }
        public int LiveId { get; set; }
        public int MyUserId { get; set; }
        public DateTime SeareDateTime { get; set; }
    }
}
