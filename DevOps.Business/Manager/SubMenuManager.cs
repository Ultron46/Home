using DevOps.Business.Interfaces;
using DevOps.Data.Interfaces;
using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Business.Manager
{
    public class SubMenuManager : ISubMenuManager
    {
        private ISubMenuDataRepository _subMenuDataRepository;

        public SubMenuManager(ISubMenuDataRepository subMenuDataRepository)
        {
            _subMenuDataRepository = subMenuDataRepository;
        }
        public List<SubMenu> GetSubMenus(int id)
        {
            return _subMenuDataRepository.GetSubMenus(id);
        }
    }
}
