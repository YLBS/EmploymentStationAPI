using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemGoodsRegion
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public int ProvId { get; set; }
        public int CityId { get; set; }
        public int CountId { get; set; }
        public int StreetId { get; set; }
        public string VillageName { get; set; } = null!;
        public DateTime CreateDateTime { get; set; }
    }
}
