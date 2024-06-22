using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngWxPusMassage
    {
        public int Id { get; set; }
        /// <summary>
        /// 0 为个人 1 为企业
        /// </summary>
        public int PusType { get; set; }
    }
}
