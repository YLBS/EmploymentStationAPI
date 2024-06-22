using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MyPosCollectionRecord
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public int PosId { get; set; }
        public DateTime CreatTime { get; set; }
        /// <summary>
        /// 是否收藏(0 不收藏 1收藏 ) 默认值为0
        /// </summary>
        public bool IsCollection { get; set; }
    }
}
