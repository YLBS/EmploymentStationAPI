using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubServiceHelp
    {
        public int Id { get; set; }
        public byte UserType { get; set; }
        public int UserId { get; set; }
        public int HelpType { get; set; }
        public string HelpTitle { get; set; } = null!;
        public string HelpMemo { get; set; } = null!;
        public string Tel { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ReplyMemo { get; set; } = null!;
        public bool IsReply { get; set; }
        public bool IsEnd { get; set; }
        public DateTime InsertDate { get; set; }
        public string ImagePath { get; set; } = null!;
    }
}
