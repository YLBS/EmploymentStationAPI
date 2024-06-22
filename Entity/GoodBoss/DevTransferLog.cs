using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class DevTransferLog
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int Sender { get; set; }
        public string? SendWhy { get; set; }
        public DateTime SendDate { get; set; }
        public byte TransferMark { get; set; }
        public int Receiver { get; set; }
        public DateTime? ActionDate { get; set; }
    }
}
