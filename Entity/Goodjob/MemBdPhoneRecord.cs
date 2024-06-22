using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemBdPhoneRecord
    {
        public int Id { get; set; }
        public string Phone { get; set; } = null!;
        public DateTime LastLoginDate { get; set; }
        public int MemId { get; set; }
        public DateTime BdDate { get; set; }
        public bool IsDefault { get; set; }
        public string TureName { get; set; } = null!;
    }
}
