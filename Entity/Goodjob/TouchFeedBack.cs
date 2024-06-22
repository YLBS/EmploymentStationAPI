using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class TouchFeedBack
    {
        public int Fid { get; set; }
        public int MyUserId { get; set; }
        public byte FeedType { get; set; }
        public string FeedDescription { get; set; } = null!;
        public string FeedContact { get; set; } = null!;
        public DateTime FeedDate { get; set; }
    }
}
