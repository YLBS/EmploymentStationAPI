using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PicGoodjobWithPic
    {
        public int Id { get; set; }
        public int PicGoodjobId { get; set; }
        public string BigPicSize { get; set; } = null!;
        public string SmallPicSize { get; set; } = null!;
        public string PhotoPath { get; set; } = null!;
    }
}
