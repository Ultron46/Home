using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.DataEntities
{
    public static class DAL
    {
        static DMSEntities DbContext;
        static DAL()
        {
            DbContext = new DMSEntities();
        }
        public static List<Dealer> GetAllDealers()
        {
            return DbContext.Dealers.ToList();
        }
        public static Dealer GetDealer(int dealerId)
        {
            return DbContext.Dealers.Where(p => p.DealerID == dealerId).FirstOrDefault();
        }
        public static bool InsertProduct(Dealer productItem)
        {
            bool status;
            try
            {
                DbContext.Dealers.Add(productItem);
                DbContext.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        public static bool UpdateProduct(Dealer productItem)
        {
            bool status;
            try
            {
                Dealer prodItem = DbContext.Dealers.Where(p => p.DealerID == productItem.DealerID).FirstOrDefault();
                if (prodItem != null)
                {
                    prodItem.DealerName = productItem.DealerName;
                    prodItem.CreatedBy = productItem.CreatedBy;
                    prodItem.CreatedDate = productItem.CreatedDate;
                    DbContext.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        public static bool DeleteProduct(int id)
        {
            bool status;
            try
            {
                Dealer prodItem = DbContext.Dealers.Where(p => p.DealerID == id).FirstOrDefault();
                if (prodItem != null)
                {
                    DbContext.Dealers.Remove(prodItem);
                    DbContext.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
    }
}
