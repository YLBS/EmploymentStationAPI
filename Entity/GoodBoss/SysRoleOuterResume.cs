using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    /// <summary>
    /// 外网简历管理系统角色表
    /// </summary>
    public partial class SysRoleOuterResume
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string RoleMemo { get; set; } = null!;
    }
}
