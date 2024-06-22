using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubHelpTopic
    {
        public int TopicId { get; set; }
        public string Question { get; set; } = null!;
        public string Answer { get; set; } = null!;
        public int ItemId { get; set; }
        public int TopicOrder { get; set; }
        public int IssuerId { get; set; }
        public string IssuerName { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public bool Disabled { get; set; }
    }
}
