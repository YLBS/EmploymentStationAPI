using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewInformation
    {
        public int InfoId { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public int IssuedArea { get; set; }
        public string? AreaRemark { get; set; }
        public string Heading { get; set; } = null!;
        public string? New { get; set; }
        public string? Important { get; set; }
        public int? KeepDay { get; set; }
        public int? IssuedDept { get; set; }
        public string? Department { get; set; }
        public string? IssuerName { get; set; }
        public DateTime? IssuedDate { get; set; }
        public int Publisher { get; set; }
        public string PublisherName { get; set; } = null!;
        public DateTime PublishDate { get; set; }
        public int Hits { get; set; }
        public string InfoContent { get; set; } = null!;
        public bool IsDelete { get; set; }
        public int? DayValue { get; set; }
    }
}
