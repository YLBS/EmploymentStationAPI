using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmAdPlaceBack
    {
        public int PlaceId { get; set; }
        public string? PlaceName { get; set; }
        public string Site { get; set; } = null!;
        public string Page { get; set; } = null!;
        public string? Area { get; set; }
        public string? ClassName { get; set; }
        public string? AdSize { get; set; }
        public int MaxApply { get; set; }
        public int MaxOnline { get; set; }
        public bool IsPause { get; set; }
        public string? Url { get; set; }
    }
}
