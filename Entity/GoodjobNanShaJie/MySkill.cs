using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MySkill
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string SkillName { get; set; } = null!;
        public string? SkillLevel { get; set; }
        public string? SkillDescribe { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
