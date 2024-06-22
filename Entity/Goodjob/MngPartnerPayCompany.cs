using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngPartnerPayCompany
    {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public int SiteId { get; set; }
        public int MemId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ReceiveMoney { get; set; }
        public int PayMoney { get; set; }
        public bool Payed { get; set; }
        public DateTime PayDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
