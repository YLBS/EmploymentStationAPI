using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PicGoodjob
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Address { get; set; } = null!;
        public string CoverPhotoPath { get; set; } = null!;
    }
}
