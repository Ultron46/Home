using DevOps.Business.Interfaces;
using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DevOps.Controllers
{
    [EnableCorsAttribute("*","*","*")]
    public class SubMenuController : ApiController
    {
        private ISubMenuManager _subMenuManager;

        public SubMenuController(ISubMenuManager subMenuManager)
        {
            _subMenuManager = subMenuManager;
        }

        public IHttpActionResult GetSubMenus(int id)
        {
            List<SubMenu> subMenus = _subMenuManager.GetSubMenus(id);
            if(subMenus == null)
            {
                return NotFound();
            }
            return Ok(subMenus);
        }
    }
}
