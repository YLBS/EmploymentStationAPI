using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphClickPhoneRecord
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public int MyUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int ZphId { get; set; }
    }
}
