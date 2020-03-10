using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Data.Interfaces
{
    public interface ISubMenuDataRepository
    {
        List<SubMenu> GetSubMenus(int id);
    }
}
