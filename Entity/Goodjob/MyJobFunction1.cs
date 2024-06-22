using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyJobFunction1
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        /// <summary>
        /// 三级
        /// </summary>
        public int JobFunctionId { get; set; }
        public int JobFunctionBig { get; set; }
        public int JobFunctionSmall { get; set; }
    }
}
