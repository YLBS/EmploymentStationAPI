using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class DicJob
    {
        public int Id { get; set; }
        public string JobName { get; set; } = null!;
        public string JobResponsibilities { get; set; } = null!;
        public string JobRequirements { get; set; } = null!;
    }
}
