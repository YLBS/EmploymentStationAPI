using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngLiveLottery
    {
        public int Id { get; set; }
        public int LiveId { get; set; }
        public int MyUserId { get; set; }
        public DateTime LotteryTime { get; set; }
        public string LotteryKey { get; set; } = null!;
        public int NumberRounds { get; set; }
        public string MatchPhoneKey { get; set; } = null!;
        public DateTime? UpdateTime { get; set; }
        public int? MatchNumberRoundsKey { get; set; }
    }
}
