using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyEducationEng
    {
        public int Id { get; set; }
        public int MyuserId { get; set; }
        public string BeginDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public string SchoolName { get; set; } = null!;
        public string Speciality { get; set; } = null!;
        public string Certificate { get; set; } = null!;
        public byte DegreeId { get; set; }
        public string SpecialityMemo { get; set; } = null!;
    }
}
