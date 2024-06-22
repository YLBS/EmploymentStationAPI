using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyUserType
    {
        public int Id { get; set; }
        public short MyTypeId { get; set; }
        public int MyUserId { get; set; }
        public DateTime GraduationDate { get; set; }
    }
}
