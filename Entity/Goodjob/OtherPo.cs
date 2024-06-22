using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class OtherPo
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public string PositionName { get; set; } = null!;
        public int CompanyId { get; set; }
        public string CompanyFullName { get; set; } = null!;
        /// <summary>
        /// 0 俊才 1.前程 2.boss 3.58 4.智联 5拉钩
        /// </summary>
        public int SourceType { get; set; }
        public string SourceName { get; set; } = null!;
        public int JcPosId { get; set; }
    }
}
