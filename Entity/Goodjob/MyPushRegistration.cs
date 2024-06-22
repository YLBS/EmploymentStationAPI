using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyPushRegistration
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string RegistrationId { get; set; } = null!;
        public DateTime? UpdateDateTime { get; set; }
        public string? Mtype { get; set; }
    }
}
