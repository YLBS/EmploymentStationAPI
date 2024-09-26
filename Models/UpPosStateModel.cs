using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UpPosStateModel
    {
        /// <summary>
        /// 驿站Id
        /// </summary>
        public int esId { get; set; }
        /// <summary>
        /// 企业Id
        /// </summary>
        public int memId { get; set; }
        /// <summary>
        /// posIds
        /// </summary>
        public int[] posIds { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int state { get; set; }
    }
}
