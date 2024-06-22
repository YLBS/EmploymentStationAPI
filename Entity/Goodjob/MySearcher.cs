using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MySearcher
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string SearcherName { get; set; } = null!;
        public string JobLocation { get; set; } = null!;
        public string JobFunction { get; set; } = null!;
        public string Calling { get; set; } = null!;
        public int PosPostDate { get; set; }
        public string KeyWord { get; set; } = null!;
        public byte KeyWordType { get; set; }
        public byte PosType { get; set; }
        public int Degree1 { get; set; }
        public int Degree2 { get; set; }
        public bool? IncludeDegree { get; set; }
        public byte WorkedYear1 { get; set; }
        public byte WorkedYear2 { get; set; }
        public bool? IncludeWorkedYear { get; set; }
        public byte Salary1 { get; set; }
        public byte Salary2 { get; set; }
        public bool? IncludeSalary { get; set; }
        public byte Sex { get; set; }
        public short Age { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool SubscibeFlag { get; set; }
        public string Email { get; set; } = null!;
    }
}
