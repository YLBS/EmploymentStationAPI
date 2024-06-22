using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    /// <summary>
    /// 外网简历管理系统角色赋权表
    /// </summary>
    public partial class SysUserInRoleOuterResume
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
