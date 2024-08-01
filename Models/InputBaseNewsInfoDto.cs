using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 添加文章Dto
    /// </summary>
    public class InputBaseNewsInfoDto
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; } = null!;
        /// <summary>
        /// 文章类型
        /// </summary>
        public string ArticleType { get; set; } = null!;
        /// <summary>
        /// 内容
        /// </summary>
        public string ContentText { get; set; } = null!;
        /// <summary>
        /// 访问次数
        /// </summary>
        public int HitCount { get; set; }
        /// <summary>
        /// 热度类型
        /// </summary>
        public int Matk { get; set; }
    }
}
