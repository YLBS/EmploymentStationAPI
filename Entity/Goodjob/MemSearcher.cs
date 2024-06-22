using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemSearcher
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string SearcherName { get; set; } = null!;
        public string KeyWord { get; set; } = null!;
        public int ResumeUpdatedate { get; set; }
        public string JobFunction { get; set; } = null!;
        public string JobLocation { get; set; } = null!;
        public int LocationP { get; set; }
        public int LocationC { get; set; }
        public int HomeTownP { get; set; }
        public int HomeTownC { get; set; }
        public int ReqDegreeId1 { get; set; }
        public int ReqDegreeId2 { get; set; }
        public byte ReqSex { get; set; }
        public byte ReqAge1 { get; set; }
        public byte ReqAge2 { get; set; }
        public byte ReqWorkYear1 { get; set; }
        public byte ReqWorkYear2 { get; set; }
        public string SchoolName { get; set; } = null!;
        public string Speciality { get; set; } = null!;
        public string LastPosName { get; set; } = null!;
        public byte LanguageId { get; set; }
        public byte LanguageLevel { get; set; }
        public bool PhotoFlag { get; set; }
        public byte EngResumeFlag { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool SubscribeFlag { get; set; }
        public byte SubscribeCycle { get; set; }
        public string Email { get; set; } = null!;
        public int LocationT { get; set; }
        public string? NewJobLocation { get; set; }
    }
}
