using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Business.Interfaces
{
    public interface ISubMenuManager
    {
        List<SubMenu> GetSubMenus(int id);
    }
}
