using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WishApp.Models;

namespace WishApp.Controllers
{
    public class UsersApiController : ApiController
    {
        
         //GET: api/UsersApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //GetChristmas
        //return all christmas preferences
        //http://localhost:65375/Christmas
        [Route("Christmas")]
        public IEnumerable<User> GetChristmas()
        {
            WishAppContext dbContext = new WishAppContext();
            var query = from p in dbContext.Preferences
                        where p.Occasions == Occasionals.Christmas
                        select p.User;
            //linq query to find data


            return query;

                
               
           

            
            //return new string[] { "Hooray", "Hooray" };
        }
        //find post by Id
        [Route("GetId/{Id}")]
        public IHttpActionResult GetId(int Id)
        {
           
                       // where p.Categories.CategoryName == "Seafood"
            //select p;
//IEnumerable<Product> products = query.ToList();
            //using(myDb)
            //{
            //    var m     (x => x.UserId == Id);
            //        //UserPrefernce.FirstOrDefault(c => c.UserId == Id);
            //    if (myId != null)
            //    {
            //        return Ok(myPost);
            //    }
            //}

            
            return BadRequest("Invalid Id");
        }

        // GET: api/UsersApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UsersApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UsersApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UsersApi/5
        public void Delete(int id)
        {
        }
    }
}
