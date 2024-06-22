using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemInfo
    {
        public int MemId { get; set; }
        public string MemName { get; set; } = null!;
        public string LicenceNumber { get; set; } = null!;
        public byte Calling { get; set; }
        public byte Properity { get; set; }
        public DateTime FoundDate { get; set; }
        public byte RegisterFund { get; set; }
        public byte EmployeeNumber { get; set; }
        public string CompanyIntroduction { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string ContactDepartment { get; set; } = null!;
        public string ContactTelZ { get; set; } = null!;
        public string ContactTel { get; set; } = null!;
        public string ContactTelE { get; set; } = null!;
        public string OldContactTel { get; set; } = null!;
        public bool TelShowFlag { get; set; }
        public string ContactFaxZ { get; set; } = null!;
        public string ContactFax { get; set; } = null!;
        public string ContactFaxE { get; set; } = null!;
        public bool FaxShowFlag { get; set; }
        public string Email { get; set; } = null!;
        public bool EmailShowFlag { get; set; }
        public int AddressP { get; set; }
        public int AddressC { get; set; }
        public string Address { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string HomePage { get; set; } = null!;
        public byte MailCode { get; set; }
        public string LogoFileName { get; set; } = null!;
        public DateTime LogoUpdatedate { get; set; }
        public byte LogoShowFlag { get; set; }
        public bool Iscommend { get; set; }
        public bool HasPage { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? AddressT { get; set; }
        public string Qq { get; set; } = null!;
        public bool Qqflag { get; set; }
        public string Phone { get; set; } = null!;
        public bool PhoneFlag { get; set; }
    }
}
