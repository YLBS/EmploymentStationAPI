using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyQqloginDatum
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string OpenId { get; set; } = null!;
    }
}
