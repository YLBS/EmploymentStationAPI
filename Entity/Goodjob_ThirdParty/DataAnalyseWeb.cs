using System;
using System.Collections.Generic;

namespace Entity.Goodjob_ThirdParty
{
    public partial class DataAnalyseWeb
    {
        public int Id { get; set; }
        public DateTime AnalyseDate { get; set; }
        public string Item { get; set; } = null!;
        public int CountIt { get; set; }
        public string AnalyseType { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime InsertDateTime { get; set; }
    }
}
