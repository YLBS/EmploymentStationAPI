using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyCompanyTopicAndComment
    {
        public int Id { get; set; }
        public int TopicType { get; set; }
        public int MyUserId { get; set; }
        public int CompanyId { get; set; }
        public string Topic { get; set; } = null!;
        public string? Content { get; set; }
        public int TopicId { get; set; }
        public int? ReadCount { get; set; }
        public DateTime AddDate { get; set; }
        public bool Enabled { get; set; }
    }
}
