using DevOps.Data.Interfaces;
using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Data.DataRepository
{
    public class MainMenuDataRepository : IMainMenuDataRepository
    {
        private DevOpsEntities DevOpsEntities;

        public MainMenuDataRepository()
        {
            DevOpsEntities = new DevOpsEntities();
        }

        public List<MainMenu> GetMainMenus()
        {
            return DevOpsEntities.MainMenus.ToList();
        }
    }
}
