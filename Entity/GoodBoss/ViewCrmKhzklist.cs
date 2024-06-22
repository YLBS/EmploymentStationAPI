using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmKhzklist
    {
        public int ComId { get; set; }
        public string ComName { get; set; } = null!;
        public int CsId { get; set; }
        public DateTime? Cetime { get; set; }
        public int? CollEplId { get; set; }
        public string EplName { get; set; } = null!;
        public int EplId { get; set; }
        public string? Khzeplname { get; set; }
        public int ProvId { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
