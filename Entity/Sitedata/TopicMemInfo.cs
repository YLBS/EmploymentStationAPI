using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class TopicMemInfo
    {
        public int MemId { get; set; }
        public string MemName { get; set; } = null!;
        public byte Calling { get; set; }
        public DateTime AddDate { get; set; }
        public int TopicId { get; set; }
    }
}
