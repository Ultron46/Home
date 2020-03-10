using DevOps.DataEntities.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using DevOps.DataEntities;

namespace DevOps.Controllers
{
    public class ProductsController : ApiController
    {
        //private DAL db = new DAL();
        [HttpGet]
        public JsonResult<List<Dealer>> GetAllDealers()
        {
            List<Dealer> dealers = DAL.GetAllDealers();
            return Json<List<Dealer>>(dealers);
        }
        [HttpGet]
        public JsonResult<Dealer> GetDealer(int id)
        {

            var dealer = DAL.GetDealer(id);
            Dealer dealers = new Dealer();
            dealers = dealer;
            return Json<Dealer>(dealers);
        }
        [HttpPost]
        public bool InsertProduct(Dealer product)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                Dealer productTemp = new Dealer();
                status = DAL.InsertProduct(product);
            }
            return status;
        }
        [HttpPut]
        public bool UpdateProduct(Dealer product)
        {
            bool status = false;
            Dealer productTemp = new Dealer();
            status = DAL.UpdateProduct(product);
            return status;
        }
        [HttpDelete]
        public bool DeleteProduct(int id)
        {
            bool status = false;
            status = DAL.DeleteProduct(id);
            return status;
        }
    }
}
