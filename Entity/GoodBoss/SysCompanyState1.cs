using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysCompanyState1
    {
        public int Id { get; set; }
        public int CsId { get; set; }
        public string CsName { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public DateTime Registerdate { get; set; }
    }
}
