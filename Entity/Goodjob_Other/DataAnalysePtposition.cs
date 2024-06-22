using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class DataAnalysePtposition
    {
        public int Id { get; set; }
        public DateTime AnalyseDate { get; set; }
        public string Item { get; set; } = null!;
        public int CountIt { get; set; }
        public DateTime InsertDateTime { get; set; }
        public int ItemId { get; set; }
    }
}
