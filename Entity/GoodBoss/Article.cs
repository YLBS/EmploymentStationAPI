using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class Article
    {
        public Guid ArtId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public short? Type { get; set; }
        public string? From { get; set; }
        public string? Author { get; set; }
        public string? Tags { get; set; }
        public DateTime? InTime { get; set; }
    }
}
