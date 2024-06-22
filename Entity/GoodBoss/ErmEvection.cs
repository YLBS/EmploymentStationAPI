using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ErmEvection
    {
        public int Id { get; set; }
        public int DptId { get; set; }
        public int EplId { get; set; }
        public int ProvId { get; set; }
        public int CityId { get; set; }
        public string Area { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public string? Memo { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalDay { get; set; }
        public int TotalHour { get; set; }
        public int TotalMinute { get; set; }
        public int TrafficDay { get; set; }
        public int TrafficHour { get; set; }
        public int TrafficMinute { get; set; }
        public int WorkDay { get; set; }
        public int WorkHour { get; set; }
        public int WorkMinute { get; set; }
        public string CompanyName { get; set; } = null!;
        public string CompanySize { get; set; } = null!;
        public string LinkMan { get; set; } = null!;
        public string LinkTel { get; set; } = null!;
        public string CompanyForecast { get; set; } = null!;
        public string MakeProtocol { get; set; } = null!;
        public int TrialEplId { get; set; }
        public DateTime? TrialDate { get; set; }
        public int CheckEplId { get; set; }
        public DateTime? CheckDate { get; set; }
        public int Status { get; set; }
        public int EvectionType { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
