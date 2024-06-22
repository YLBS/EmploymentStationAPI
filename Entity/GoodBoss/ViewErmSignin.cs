using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewErmSignin
    {
        public int Id { get; set; }
        public string Insertdate { get; set; } = null!;
        public int Uid { get; set; }
        public string Morningtime { get; set; } = null!;
        public string Afternoontime { get; set; } = null!;
        public byte Morningbz { get; set; }
        public byte Afternoonbz { get; set; }
        public string Fromip { get; set; } = null!;
        public string FromipLast { get; set; } = null!;
        public string MorningbzFlag { get; set; } = null!;
        public string AfternoonbzFlag { get; set; } = null!;
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public int DptId { get; set; }
        public int? Moring { get; set; }
        public int? Afternoon { get; set; }
    }
}
