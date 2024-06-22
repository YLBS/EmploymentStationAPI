using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    /// <summary>
    /// 外网简历管理角色权限表
    /// </summary>
    public partial class SysMenuInRoleOuterResume
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public int RoleId { get; set; }
    }
}
