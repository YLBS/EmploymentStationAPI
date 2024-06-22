using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemPushRegistration
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string RegistrationId { get; set; } = null!;
        public DateTime? UpdateDateTime { get; set; }
        /// <summary>
        /// 1 Android 2 IOS
        /// </summary>
        public int? Rtype { get; set; }
    }
}
