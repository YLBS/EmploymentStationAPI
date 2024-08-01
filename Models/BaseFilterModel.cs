using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseFilterModel
    {
        /// <summary>
        /// 页码
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "传大于0的整数")]
        [Required(ErrorMessage = "必填")]
        public int PageIndex { get; set; } = 1;
        /// <summary>
        /// 每页数量，最少10条
        /// </summary>
        [Range(10, int.MaxValue, ErrorMessage = "传大于等于10的整数")]
        [Required(ErrorMessage = "必填")]
        public int PageSize { get; set; } = 10;
        /// <summary>
        /// 查询关键字，一般为名称
        /// </summary>
        public string? Name { get; set; }
    }
}
