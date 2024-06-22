using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubMemOnline
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public DateTime RefreshDate { get; set; }
        public bool IsOnline { get; set; }
    }
}
