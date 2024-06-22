using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyLanguageEng
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public byte LanguageId { get; set; }
        public byte LanguageLevel { get; set; }
        public string LanguageDescription { get; set; } = null!;
    }
}
