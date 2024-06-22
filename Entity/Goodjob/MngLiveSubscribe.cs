using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngLiveSubscribe
    {
        public int Id { get; set; }
        public int LiveId { get; set; }
        public int MyUserId { get; set; }
        public DateTime SubscribeTime { get; set; }
    }
}
