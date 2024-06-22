using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewForumMessage
    {
        public int MsgId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string ReplyMan { get; set; } = null!;
        public string MsgTitle { get; set; } = null!;
        public string MsgContent { get; set; } = null!;
        public DateTime InTime { get; set; }
        public string InIp { get; set; } = null!;
        public int MsgHit { get; set; }
        public int? ReplyHit { get; set; }
        public int PlateId { get; set; }
        public int IsPass { get; set; }
        public byte? MessType { get; set; }
        public int? ParentId { get; set; }
        public string PlateName { get; set; } = null!;
        public int PlateOrder { get; set; }
        public string? PlateStyle { get; set; }
        public string? Picture { get; set; }
        public int? DptId { get; set; }
        public int? EsId { get; set; }
        public string? Memo { get; set; }
        public string? DptName { get; set; }
        public string? PosName { get; set; }
        public DateTime? PosiDate { get; set; }
        public string? Bqq { get; set; }
        public string? Interest { get; set; }
        public string? Address { get; set; }
        public string? Area { get; set; }
        public string? PhoneZ { get; set; }
        public string? PhoneN { get; set; }
        public string? PhoneE { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public DateTime? Birthday { get; set; }
        public string? EplName { get; set; }
        public byte? Sex { get; set; }
        public byte? Marry { get; set; }
        public string? IdCard { get; set; }
        public int? DgrId { get; set; }
        public string? SchoolName { get; set; }
        public string? Speciality { get; set; }
        public string? Diploma { get; set; }
        public string? Headship { get; set; }
        public string? Protocol { get; set; }
        public string? Tongue { get; set; }
        public string? Nation { get; set; }
        public int? ProvId { get; set; }
        public int? CityId { get; set; }
        public string? PostCode { get; set; }
        public string? LnkMan { get; set; }
        public string? LnkTel { get; set; }
        public int? PosId { get; set; }
        public int? Enable { get; set; }
        public bool? LimitIp { get; set; }
        public string? IpAddress { get; set; }
        public DateTime? LeaveDate { get; set; }
        public DateTime? EnterDate { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? ReplyLastTime { get; set; }
        public int? ThisMark { get; set; }
        public byte? Type { get; set; }
        public int? Dayvalue { get; set; }
    }
}
