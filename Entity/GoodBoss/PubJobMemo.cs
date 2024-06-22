using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PubJobMemo
    {
        public int Id { get; set; }
        public int EplId { get; set; }
        public string Title { get; set; } = null!;
        public string Memo { get; set; } = null!;
        public string BeginTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public int ProvId { get; set; }
        public int CityId { get; set; }
        public string Area { get; set; } = null!;
        public int MemoType { get; set; }
        public short FinishFlag { get; set; }
        public string MemoDate { get; set; } = null!;
        public DateTime RegisterDate { get; set; }
    }
}
