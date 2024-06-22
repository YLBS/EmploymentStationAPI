using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class QdResult
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int QdPerpleId { get; set; }
        public string? Result { get; set; }
        public DateTime? QdTime { get; set; }
    }
}
