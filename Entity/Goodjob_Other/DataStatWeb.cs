using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class DataStatWeb
    {
        public int Id { get; set; }
        public int Ayear { get; set; }
        public int Amonth { get; set; }
        public int Aweek { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public byte InFlag { get; set; }
        public DateTime InDate { get; set; }
    }
}
