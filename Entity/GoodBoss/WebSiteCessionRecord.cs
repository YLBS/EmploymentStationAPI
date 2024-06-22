using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class WebSiteCessionRecord
    {
        public int Tid { get; set; }
        public int? ClientId { get; set; }
        public byte? Status { get; set; }
        public int? EplId { get; set; }
        public int? InUser { get; set; }
        public string? Remark { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string? UserName { get; set; }
        public int? UserId { get; set; }
        public string? UserIp { get; set; }
        public DateTime? InTime { get; set; }
    }
}
