using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class DicKeyword
    {
        public int Id { get; set; }
        public string Keyword { get; set; } = null!;
        public int SearchedCount { get; set; }
        public DateTime AddDate { get; set; }
        public string Channel { get; set; } = null!;
        public int ChannelId { get; set; }
        public string Position { get; set; } = null!;
        public int IsCompanyOrPos { get; set; }
    }
}
