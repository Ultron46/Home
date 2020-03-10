using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Common
{
    public class Enums
    {
        public enum Roles
        {
            Admin = 1,
            [Display(Name = "Release Manager")]
            ReleaseManaegr = 2,
            User = 3
        }
    }
}
