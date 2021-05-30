using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TBApp.DAL;
using TBApp.Models;

namespace TBApp.Controllers
{
    public class ItemController : ApiController
    {
        // GET api/ShopBridge
        public string Get()
        {
            string result = "";
            DataAccessLayer objDal = new DataAccessLayer();

            result = objDal.GetDetails();

            return result;

        }

        // GET api/ShopBridge/5
        public string Get(int id)
        {
            string result = "";
            DataAccessLayer objDal = new DataAccessLayer();

            result = objDal.GetDetails(id);

            return result;
        }

        // POST api/ShopBridge
        public string Post([FromBody] ItemModel En)
        {

            
                string result = "";
                DataAccessLayer objDal = new DataAccessLayer();

                result = objDal.Post(En);

                return result;


           
        }

        // PUT api/ShopBridge/5
        public string Put(int id, [FromBody] ItemModel En)
        {
           
           
                string result = "";
                DataAccessLayer objDal = new DataAccessLayer();

                result = objDal.Put(id, En);

                return result;
            
        }

        // DELETE api/ShopBridge/5
        public string Delete(int id)
        {
            string result = "";
            DataAccessLayer objDal = new DataAccessLayer();

            result = objDal.delete(id);

            return result;


        }
    }
}
