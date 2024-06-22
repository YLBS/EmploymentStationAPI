using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class MngPopsite
    {
        public int Id { get; set; }
        public string SiteName { get; set; } = null!;
        public string Domain { get; set; } = null!;
        public string FolderName { get; set; } = null!;
        public bool Disabled { get; set; }
        public bool Special { get; set; }
    }
}
