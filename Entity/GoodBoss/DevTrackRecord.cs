using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class DevTrackRecord
    {
        public int TrackId { get; set; }
        public int ClientId { get; set; }
        public int Tracker { get; set; }
        public DateTime TrackDate { get; set; }
        public int TrackTypeId { get; set; }
        public string Content { get; set; } = null!;
    }
}
