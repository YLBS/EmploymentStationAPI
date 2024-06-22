using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngLiveFabulou
    {
        public int Id { get; set; }
        public int LiveId { get; set; }
        public int MyUserId { get; set; }
        public DateTime FabulousTime { get; set; }
        public string FabulousKey { get; set; } = null!;
    }
}
