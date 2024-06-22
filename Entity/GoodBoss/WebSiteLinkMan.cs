using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class WebSiteLinkMan
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string? Sex { get; set; }
        public string? Name { get; set; }
        public string? PosName { get; set; }
        public string? BraName { get; set; }
        public string? Mobile { get; set; }
        public string? PhoneA { get; set; }
        public string? PhoneB { get; set; }
        public string? PhoneC { get; set; }
        public string? FaxA { get; set; }
        public string? FaxB { get; set; }
        public string? FaxC { get; set; }
        public string? Email { get; set; }
        public string? Qq { get; set; }
        public DateTime? InTime { get; set; }
        public bool? IsMain { get; set; }
        public int? UserId { get; set; }
    }
}
