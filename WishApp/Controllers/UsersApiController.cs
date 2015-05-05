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
        
         //GET: api/UsersApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //GetChristmas
        //return all christmas preferences
        //http://localhost:65375/Christmas
        [Route("Christmas")]
        public IEnumerable<ChristmasUser> GetChristmas()
        {
            WishAppContext dbContext = new WishAppContext();
            //from team in new[]{fixture.AwayTeam, fixture.HomeTeam}
            var query = from p in dbContext.Preferences
                        //from q in dbContext.Users
                        where p.Occasions == Occasionals.Christmas
                        select new ChristmasUser() { UserName = p.User.Email, Occ = p.Occasions.ToString(), Pref = p.UserPreference };
            // select p.UserPreference && p.User;
            //linq query to find data


            return query;
            
            //WishAppContext dbContext = new WishAppContext();
            ////from team in new[]{fixture.AwayTeam, fixture.HomeTeam}
            //var query = from p in dbContext.Preferences
            //            where p.Occasions == Occasionals.Christmas
            //            select p;
            //           // select p.UserPreference && p.User;
            ////linq query to find data


            //return query;
 
            //return new string[] { "Hooray", "Hooray" };
        }

        //GetChristmas
        //return all christmas preferences
        //http://localhost:65375/Valentines
        [Route("Valentines")]
        public IEnumerable<ValentinesUser> GetValentines()
        {
            //var cities = weather.Where(w => w.WeatherWarning == warning).Select(w => w.City);
            //return cities; 
            WishAppContext dbContext = new WishAppContext();
            //from team in new[]{fixture.AwayTeam, fixture.HomeTeam}
            var query = from p in dbContext.Preferences 
                        //from q in dbContext.Users
                        where p.Occasions == Occasionals.Christmas
                        select new ValentinesUser() {UserName = p.User.Email, Occ = p.Occasions.ToString(), Pref = p.UserPreference};
            // select p.UserPreference && p.User;
            //linq query to find data


            return query;

            //return new string[] { "Hooray", "Hooray" };
        }

       

        // GET: api/UsersApi/5
        public string Get(int id)
        {
            return "value";
        }

       
    }
}
