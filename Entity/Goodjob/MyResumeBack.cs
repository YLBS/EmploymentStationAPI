using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyResumeBack
    {
        public int MyUserId { get; set; }
        public string PerName { get; set; } = null!;
        public byte Sex { get; set; }
        public byte Nationality { get; set; }
        public DateTime? Birthday { get; set; }
        public byte CardType { get; set; }
        public string CardNum { get; set; } = null!;
        public short Height { get; set; }
        public short Weight { get; set; }
        public byte MaritalStatus { get; set; }
        public int HometownP { get; set; }
        public int HometownC { get; set; }
        public int LocationP { get; set; }
        public int LocationC { get; set; }
        public byte DegreeId { get; set; }
        public string SelfDescription { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public string MobileNum { get; set; } = null!;
        public string Imnum { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Homepage { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string PositionName { get; set; } = null!;
        public byte ComputerLevel { get; set; }
        public string ComputerSkills { get; set; } = null!;
        public string OtherSkills { get; set; } = null!;
        public string Interesting { get; set; } = null!;
        public string JobSeeking { get; set; } = null!;
        public int Salary { get; set; }
        public string EatHouseNeeded { get; set; } = null!;
        public string OtherNeeded { get; set; } = null!;
        public byte CheckinDate { get; set; }
        public byte JobType { get; set; }
        public string CareerDirection { get; set; } = null!;
        public byte WorkedYear { get; set; }
        public byte WorkedMonth { get; set; }
        public string PhotoName { get; set; } = null!;
        public byte PhotoDisplay { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public byte ResumeStatus { get; set; }
        public string PartComName { get; set; } = null!;
        public int AllCount { get; set; }
        public DateTime? CheckDate { get; set; }
        public byte CheckFlag { get; set; }
        public byte BaseWrite { get; set; }
        public byte WorkWrite { get; set; }
        public byte EduWrite { get; set; }
        public byte TrainingWrite { get; set; }
        public byte LanguageWrite { get; set; }
        public byte HopeWrite { get; set; }
        public byte ProjectWrite { get; set; }
        public byte CertWrite { get; set; }
        public byte FulfilWrite { get; set; }
        public byte SkillWrite { get; set; }
        public byte AllWrite { get; set; }
        public int LocationT { get; set; }
        public bool IsdqStatus { get; set; }
        public int? VideoWrite { get; set; }
    }
}
