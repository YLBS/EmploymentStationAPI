﻿using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class ImAutMassage
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string Massage { get; set; } = null!;
        public DateTime Createatime { get; set; }
        public DateTime Updatetime { get; set; }
        public bool IsRemove { get; set; }
        public bool IsOffLine { get; set; }
        public int Sequence { get; set; }
    }
}