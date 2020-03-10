using DevOps.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevOps.Controllers
{
    public class MainMenuController : ApiController
    {
        private IMainMenuManager _mainMenuManager;

        public MainMenuController(IMainMenuManager mainMenuManager)
        {
            _mainMenuManager = mainMenuManager;
        }

        public IHttpActionResult GetMainMenus()
        {
            return Ok(_mainMenuManager.GetMainMenus());
        }
    }
}
