using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngPartnerContent
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int LocationP { get; set; }
        public int LocationC { get; set; }
        public int FunctionBig { get; set; }
        public int FunctionSmall { get; set; }
        public int IndustryId { get; set; }
        public int ProductTypeId { get; set; }
    }
}
