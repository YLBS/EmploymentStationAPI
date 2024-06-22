using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemFirstLoginAd
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public DateTime ShowTimestamp { get; set; }
        public int AdType { get; set; }
    }
}
