using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubImRoaming
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public DateTime? RoamingTime { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
