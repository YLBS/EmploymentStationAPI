using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemMapCoordinate
    {
        public int MemId { get; set; }
        public string Lng { get; set; } = null!;
        public string Lat { get; set; } = null!;
    }
}
