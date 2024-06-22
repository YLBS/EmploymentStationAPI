using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyResumeUploadRecord
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string UploadFile { get; set; } = null!;
        public string UploadName { get; set; } = null!;
        public DateTime UploadDate { get; set; }
    }
}
