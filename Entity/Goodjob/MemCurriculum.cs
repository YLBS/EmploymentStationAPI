using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemCurriculum
    {
        public int Id { get; set; }
        public string CName { get; set; } = null!;
        public DateTime CBegDateTime { get; set; }
        public DateTime? AddDatetime { get; set; }
        public string CAddress { get; set; } = null!;
        public string? CContext { get; set; }
        public string? CTeacher { get; set; }
        public int CMaxPeopleCount { get; set; }
        public double? CPrice { get; set; }
        public double? CDiscount { get; set; }
        public string CIntroduction { get; set; } = null!;
        public string CTeacherIntroduction { get; set; } = null!;
        public string CCover { get; set; } = null!;
    }
}
