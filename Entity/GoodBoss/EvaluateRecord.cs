using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class EvaluateRecord
    {
        public Guid Id { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public string? DptName { get; set; }
        public string? VoiceFile { get; set; }
        public DateTime? CallTime { get; set; }
        public string? Callphone { get; set; }
        public decimal CallLen { get; set; }
        public int? CallType { get; set; }
        public string? Content { get; set; }
        public decimal? Fraction { get; set; }
        public string? FraRemark { get; set; }
        public int? CateId { get; set; }
        public string? CateName { get; set; }
        public int? AdminEplId { get; set; }
        public string? AdminEplName { get; set; }
        public DateTime? InTime { get; set; }
        public short? State { get; set; }
        public int? CheckEplId { get; set; }
        public string? CheckEplName { get; set; }
        public string? CheckRemark { get; set; }
        public DateTime? CheckTime { get; set; }
        public string? Tags { get; set; }
        public int? PhoneId { get; set; }
    }
}
