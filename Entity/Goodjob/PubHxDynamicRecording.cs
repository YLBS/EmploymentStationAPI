using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubHxDynamicRecording
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public string Explain { get; set; } = null!;
        public DateTime CreadteDateTime { get; set; }
        /// <summary>
        /// 0常规 1应聘简历 2视频排队申请  3咨询消息发送 4视频面试请求 5取消视频排队申请 6视频面试中 7视频面试挂断结束
        /// </summary>
        public int DynamicType { get; set; }
        /// <summary>
        /// 招聘会id
        /// </summary>
        public int Pid { get; set; }
        public int PosId { get; set; }
        public string ConfrId { get; set; } = null!;
        public string VideoTime { get; set; } = null!;
        public int RequestId { get; set; }
        public int ResponseId { get; set; }
        public int RequestType { get; set; }
    }
}
