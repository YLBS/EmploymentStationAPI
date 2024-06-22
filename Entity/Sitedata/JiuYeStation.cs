using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class JiuYeStation
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string AffiliatedUnit { get; set; } = null!;
        public int AdminUser { get; set; }
        public int SecondaryUser { get; set; }
        public string Eaddress { get; set; } = null!;
        public int EaddressP { get; set; }
        public int EaddressC { get; set; }
        public int EaddressD { get; set; }
        public int EaddressT { get; set; }
        public string Introduce { get; set; } = null!;
        public DateTime UpDateTime { get; set; }
        public DateTime AddDateTime { get; set; }
    }
}
