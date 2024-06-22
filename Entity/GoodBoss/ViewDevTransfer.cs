using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewDevTransfer
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; } = null!;
        public string ClientTypeName { get; set; } = null!;
        public int Sender { get; set; }
        public string SenderName { get; set; } = null!;
        public int Receiver { get; set; }
        public string ReceiverName { get; set; } = null!;
        public string SendWhy { get; set; } = null!;
        public DateTime SendDate { get; set; }
        public byte TransferMark { get; set; }
        public DateTime? ActionDate { get; set; }
        public bool HaveOwner { get; set; }
    }
}
