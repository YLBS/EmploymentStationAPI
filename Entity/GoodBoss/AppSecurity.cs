using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class AppSecurity
    {
        public int Id { get; set; }
        public string Randomchar { get; set; } = null!;
        public bool State { get; set; }
        public DateTime AddDate { get; set; }
    }
}
