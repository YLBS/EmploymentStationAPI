using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewUserInRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string EplName { get; set; } = null!;
        public string? Picture { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte Level { get; set; }
        public int RoleId { get; set; }
    }
}
