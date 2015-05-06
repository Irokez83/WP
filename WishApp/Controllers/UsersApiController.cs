using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WishApp.Models;

namespace WishApp.Controllers
{
    //Display classes
    public class ValentinesUser
    {
        public String UserName { get; set; }
        public String Pref { get; set; }
        public String Occ { get; set; }
    }

    public class ChristmasUser
    {
        public String UserName { get; set; }
        public String Pref { get; set; }
        public String Occ { get; set; }
    }
    public class UsersApiController : ApiController
    {
        
        //GetChristmas
        //return all christmas preferences
        //http://localhost:65375/Christmas
        [Route("Christmas")]
        public IEnumerable<ChristmasUser> GetChristmas()
        {
            WishAppContext dbContext = new WishAppContext();
            
            var query = from p in dbContext.Preferences
                        where p.Occasions == Occasionals.Christmas
                        select new ChristmasUser() 
                        { UserName = p.User.Email, Occ = p.Occasions.ToString(), Pref = p.UserPreference };
           
            return query;
                     
        }

        //GetValentines
        //return all Valentines preferences
        //http://localhost:65375/Valentines
        [Route("Valentines")]
        public IEnumerable<ValentinesUser> GetValentines()
        {
            
            WishAppContext dbContext = new WishAppContext();
           
            var query = from p in dbContext.Preferences 
                        where p.Occasions == Occasionals.Valentines
                        select new ValentinesUser()
                        {UserName = p.User.Email, Occ = p.Occasions.ToString(), Pref = p.UserPreference};
        
            return query;
             
        }
 
    }
}
