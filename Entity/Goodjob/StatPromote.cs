using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class StatPromote
    {
        public int PromoteId { get; set; }
        public int PromoteType { get; set; }
        public int CountNum { get; set; }
        public int PersonalRegNum { get; set; }
        public int ComRegNum { get; set; }
        public int PersonalCount { get; set; }
        public int ComCount { get; set; }
        public DateTime OpenDate { get; set; }
    }
}
