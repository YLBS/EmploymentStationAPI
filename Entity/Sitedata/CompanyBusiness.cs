using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CompanyBusiness
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public string Business { get; set; } = null!;
        public string FaxNum { get; set; } = null!;
        public string MobileNum { get; set; } = null!;
        public string PhoneNum { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public string Word { get; set; } = null!;
        public int Category { get; set; }
        public bool? Enabled { get; set; }
        public string Editor { get; set; } = null!;
    }
}
