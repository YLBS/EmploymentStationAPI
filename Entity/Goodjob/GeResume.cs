using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class GeResume
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public int Sex { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; } = null!;
        public string EngWork { get; set; } = null!;
        public string Skills { get; set; } = null!;
        public int MemId { get; set; }
        public int PosId { get; set; }
        public DateTime ReceiveDate { get; set; }
        public int ApplyCount { get; set; }
        public byte ReadFlag { get; set; }
        public bool IsInterview { get; set; }
        public byte YnMsm { get; set; }
        public int AddressP { get; set; }
        public int AddressC { get; set; }
        public int AddressT { get; set; }
    }
}
