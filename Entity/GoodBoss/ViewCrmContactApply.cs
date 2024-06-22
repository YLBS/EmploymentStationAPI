using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmContactApply
    {
        public string? ComName { get; set; }
        public int ApplicantId { get; set; }
        public DateTime ApplyDate { get; set; }
        public int HasDistributed { get; set; }
        public int TaskRecipient { get; set; }
        public int IsCompleted { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactPhone { get; set; }
        public string? Email { get; set; }
        public string? WxId { get; set; }
        public string? Position { get; set; }
        public int HasContact { get; set; }
        public string? RecipientName { get; set; }
        public int ComId { get; set; }
        public int? MemId { get; set; }
        public int ApplicantDptId { get; set; }
        public string? DptName { get; set; }
        public string ApplicantName { get; set; } = null!;
        public DateTime? ComplatedDate { get; set; }
        public string? FromSite { get; set; }
        public string? OuterSiteUrl { get; set; }
        public int? DptId { get; set; }
        public string? Remark { get; set; }
    }
}
