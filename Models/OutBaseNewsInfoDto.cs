using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 输出文章Dto
    /// </summary>
    public class OutBaseNewsInfoDto: InputBaseNewsInfoDto
    {
        /// <summary>
        /// 文章Id
        /// </summary>
        public int NewsId { get; set; }
    }
}
