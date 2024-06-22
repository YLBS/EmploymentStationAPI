using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyFavouriate
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int PosId { get; set; }
        public DateTime InsertDate { get; set; }
        public string Note { get; set; } = null!;
        public int PosType { get; set; }
    }
}
