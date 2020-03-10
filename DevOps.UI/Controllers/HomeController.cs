using DevOps.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DevOps.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        string baseUrl = "http://localhost:60969/";
      

        public async Task<ActionResult> Index(string name)
        {
            return View();
        }
    }
}
