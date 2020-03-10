using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOps.UI.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public Nullable<byte> RoleId { get; set; }
        public Nullable<int> SubMenuId { get; set; }
        public byte[] Read { get; set; }
        public byte[] Write { get; set; }

        //public virtual Role Role { get; set; }
        public virtual SubMenu SubMenu { get; set; }
    }
}