using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngAreaSite
    {
        public int Id { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public string Pname { get; set; } = null!;
        public string Ename { get; set; } = null!;
        public bool Disabled { get; set; }
        public bool Important { get; set; }
    }
}
