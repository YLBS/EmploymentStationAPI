﻿using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmAbnegateTemporary
    {
        public int ComId { get; set; }
        public string ComName { get; set; } = null!;
        public int EplId { get; set; }
        public int DptId { get; set; }
        public DateTime AngDate { get; set; }
        public string EplName { get; set; } = null!;
        public int AngTypeCsId { get; set; }
        public int Callings { get; set; }
        public int ProvId { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        public int FinId { get; set; }
    }
}