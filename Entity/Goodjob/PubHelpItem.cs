using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubHelpItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public byte ItemType { get; set; }
        public int ItemOrder { get; set; }
        public bool IsDelete { get; set; }
    }
}
