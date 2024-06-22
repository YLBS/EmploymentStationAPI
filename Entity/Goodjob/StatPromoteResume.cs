using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class StatPromoteResume
    {
        public int PromoteId { get; set; }
        public int ResumeId { get; set; }
        public int PromoteType { get; set; }
        public int PersonalRegNum { get; set; }
        public int ComRegNum { get; set; }
        public DateTime OpenDate { get; set; }
    }
}
