using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class TopicInfo
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; } = null!;
        public string TopicIntroduction { get; set; } = null!;
        public string TopicProjectbrief { get; set; } = null!;
        public string TopicConfigurationinfo { get; set; } = null!;
        public string TopicStyle { get; set; } = null!;
        public string TopickContact { get; set; } = null!;
        public string TopickPreferential { get; set; } = null!;
        public string TopickServices { get; set; } = null!;
        public string TopickLawguide { get; set; } = null!;
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
