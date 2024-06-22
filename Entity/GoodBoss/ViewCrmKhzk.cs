using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmKhzk
    {
        public int ComId { get; set; }
        public string ComName { get; set; } = null!;
        public int State { get; set; }
        public string LiyouText { get; set; } = null!;
        public DateTime ShenheDateTime { get; set; }
        public int ShenheState { get; set; }
        public DateTime EndDateTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public int EplId { get; set; }
        public int Expr1 { get; set; }
        public int Id { get; set; }
        public int MemId { get; set; }
        public int Expr2 { get; set; }
        public string EplName { get; set; } = null!;
        public int CsId { get; set; }
        public DateTime? Cetime { get; set; }
        public int? CollEplId { get; set; }
        public string? Khzeplname { get; set; }
        public string? Yyhzreplname { get; set; }
        public DateTime? LastLinkDate { get; set; }
        public int CrmCompanyEplId { get; set; }
    }
}
