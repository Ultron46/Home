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
    public class MainMenuManager : IMainMenuManager
    {
        private IMainMenuDataRepository _mainMenuDataRepository;

        public MainMenuManager(IMainMenuDataRepository mainMenuDataRepository)
        {
            _mainMenuDataRepository = mainMenuDataRepository;
        }

        public List<MainMenu> GetMainMenus()
        {
            return _mainMenuDataRepository.GetMainMenus();
        }
    }
}
