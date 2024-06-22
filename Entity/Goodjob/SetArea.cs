using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class SetArea
    {
        public int Id { get; set; }
        public string AreaName { get; set; } = null!;
        public string AreaEnName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Keywords { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int AddressP { get; set; }
        public int AddressC { get; set; }
        public string TitleT { get; set; } = null!;
        public string TitleL { get; set; } = null!;
        public string TitleR { get; set; } = null!;
        public string TitleD { get; set; } = null!;
        public string TitleC { get; set; } = null!;
        public string Comprehensive { get; set; } = null!;
        public string Focus { get; set; } = null!;
        public string PosidAll { get; set; } = null!;
        public string Yngeneration { get; set; } = null!;
    }
}
