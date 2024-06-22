using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphBlack
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int ZphAdminId { get; set; }
        public int ZphId { get; set; }
        public bool IsRelieve { get; set; }
        public DateTime InDateTime { get; set; }
        public DateTime? ReDateTme { get; set; }
    }
}
