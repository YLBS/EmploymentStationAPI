using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewDevTrackRecord
    {
        public int TrackId { get; set; }
        public int ClientId { get; set; }
        public DateTime TrackDate { get; set; }
        public string TrackerName { get; set; } = null!;
        public string TrackTypeName { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
