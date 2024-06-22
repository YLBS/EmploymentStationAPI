using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysCompanyState
    {
        public int Id { get; set; }
        public int CsId { get; set; }
        public string? CsName { get; set; }
        public string? Alias { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
