using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class AnalyseHolidayDatum
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public int? Ugroup { get; set; }
        public string Uname { get; set; } = null!;
        public double Holidday { get; set; }
        public int BelateforTime { get; set; }
        public int BelateforTimeCount { get; set; }
        public int BelateforTen { get; set; }
        public int BelateforTenB { get; set; }
        public int? LateTT { get; set; }
        public int? LateTS { get; set; }
        public int? LateSTw { get; set; }
        public int? LateTw { get; set; }
        public int BackTime { get; set; }
        public int BackTimeCount { get; set; }
        public int? BackTT { get; set; }
        public int? BackTS { get; set; }
        public int? BackSTw { get; set; }
        public int? BackTw { get; set; }
        public int HolidayNumber { get; set; }
        public int KgNumber { get; set; }
        public DateTime Bdate { get; set; }
    }
}
