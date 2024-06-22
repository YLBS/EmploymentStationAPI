using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubUserqdRecord
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int UserId { get; set; }
        public DateTime QdDate { get; set; }
    }
}
