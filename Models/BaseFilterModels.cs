using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 基础
    /// </summary>
    public class BaseFilterModels
    {
       

        [Range(1, int.MaxValue, ErrorMessage = "传大于0的整数")]
        [Required(ErrorMessage="必填")]
        public int PageIndex { get; set; } = 1;
        [Range(10, int.MaxValue, ErrorMessage = "传大于等于10的整数")]
        [Required(ErrorMessage = "必填")]
        public int PageSize { get; set; } = 10;
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 关键字
        /// </summary>
        public string? Name { get; set; }

    }
}
