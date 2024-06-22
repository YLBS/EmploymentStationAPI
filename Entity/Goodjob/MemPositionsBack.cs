using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemPositionsBack
    {
        public int PosId { get; set; }
        public int MemId { get; set; }
        public string MemName { get; set; } = null!;
        public string PosName { get; set; } = null!;
        public string TagLib { get; set; } = null!;
        public byte Calling { get; set; }
        public int DeptId { get; set; }
        public int CandidatesNum { get; set; }
        public DateTime? EndValidDate { get; set; }
        public string Posdecription { get; set; } = null!;
        public byte Salary { get; set; }
        public byte PosType { get; set; }
        public int ReqDegreeId { get; set; }
        public byte ReqWorkyear { get; set; }
        public byte ReqMarital { get; set; }
        public int RegHometownP { get; set; }
        public int RegHometownC { get; set; }
        public byte ReqSex { get; set; }
        public byte ReqAge1 { get; set; }
        public byte ReqAge2 { get; set; }
        public string JobLocation { get; set; } = null!;
        public string ExamNotice { get; set; } = null!;
        public string ExamAddress { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string ContactTelZ { get; set; } = null!;
        public string ContactTel { get; set; } = null!;
        public string ContactTelE { get; set; } = null!;
        public bool TelShowFlag { get; set; }
        public string ContactFaxZ { get; set; } = null!;
        public string ContactFax { get; set; } = null!;
        public string ContactFaxE { get; set; } = null!;
        public bool FaxShowFlag { get; set; }
        public string Email { get; set; } = null!;
        public bool EmailShowFlag { get; set; }
        public byte EmailCodeFlag { get; set; }
        public int AddressP { get; set; }
        public int AddressC { get; set; }
        public string? Address { get; set; }
        public string ZipCode { get; set; } = null!;
        public byte PosState { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime PostDate { get; set; }
        public int HitCounter { get; set; }
        public bool Geyn { get; set; }
        public byte UpdateFlag { get; set; }
        public bool Hires { get; set; }
        public DateTime BeginHiresDate { get; set; }
        public string? Welfa { get; set; }
        public string? SalaryRange { get; set; }
    }
}
