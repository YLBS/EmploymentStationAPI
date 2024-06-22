using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ZphTheme
    {
        /// <summary>
        /// 招聘会编号
        /// </summary>
        public int ZhaoPinHuiId { get; set; }
        /// <summary>
        /// 招聘会名称
        /// </summary>
        public string Title { get; set; } = null!;
        /// <summary>
        /// 举报时间
        /// </summary>
        public DateTime AtTheTime { get; set; }
        /// <summary>
        /// 举办地址
        /// </summary>
        public string Address { get; set; } = null!;
        /// <summary>
        /// 摊位数
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime ByTheTime { get; set; }
        /// <summary>
        /// 注意事项
        /// </summary>
        public string Matters { get; set; } = null!;
        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime EditDate { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateDate { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int EplId { get; set; }
        /// <summary>
        /// 0 默认为开启 1 位暂停
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 性质 0公益 1收益
        /// </summary>
        public int Type { get; set; }
        public DateTime? JztheTime { get; set; }
        /// <summary>
        /// 摊位号是否确认
        /// </summary>
        public bool NumberOk { get; set; }
        /// <summary>
        /// 关联校园招聘会ID
        /// </summary>
        public int AzpHid { get; set; }
    }
}
