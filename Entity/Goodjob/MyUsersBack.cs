using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyUsersBack
    {
        public int MyUserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte EngResumeFlag { get; set; }
        public byte ReceiveMailType { get; set; }
        public DateTime RegisterDate { get; set; }
        public byte ResumeStatus { get; set; }
        public byte ContactStatus { get; set; }
        public byte DisplayFlag { get; set; }
        public byte CheckFlag { get; set; }
        public byte RegisterBy { get; set; }
        public int LoginCount { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int HitCount { get; set; }
        public string PhoneNum { get; set; } = null!;
        public bool IsAuPhone { get; set; }
        public bool IsAuEmail { get; set; }
        public bool IsRefresh { get; set; }
        public int RegisterFrom { get; set; }
    }
}
