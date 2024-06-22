using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyAuthenId
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string EncryptionStr { get; set; } = null!;
        public int AuthType { get; set; }
        public bool? Flag { get; set; }
        public DateTime SendDate { get; set; }
    }
}
