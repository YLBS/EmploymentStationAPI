using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubPerEvaluation
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public int EvaluationType { get; set; }
        public string? EvaluationMessage { get; set; }
        public DateTime EvaluateDate { get; set; }
        public bool HasReply { get; set; }
        public string? ReplyMessage { get; set; }
        public DateTime? ReplyDate { get; set; }
        public bool? Enabled { get; set; }
    }
}
