using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace WishApp.Models
{
    public class WishAppInitializer : DropCreateDatabaseIfModelChanges<WishAppContext>
    {
        //giving data for tables
        protected override void Seed(WishAppContext context)
        {
            //declaring and saving employees
            var users = new List<User>
            {
                new User { Email = "aaron@aaron.su" },
                new User { Email = "baron@baron.su" },
                new User { Email = "caron@caron.su" },
                new User { Email = "daron@daron.su" },
                new User { Email = "earon@earon.su" },
                new User { Email = "faron@faron.su" },
                new User { Email = "garon@garon.su" },
                new User { Email = "haron@haron.su" },
                new User { Email = "iaron@iaron.su" },
                new User { Email = "jaron@jaron.su" },
                new User { Email = "karon@karon.su" },
                new User { Email = "laron@laron.su" },
                new User { Email = "maron@maron.su" },
                new User { Email = "naron@naron.su" },
                new User { Email = "oaron@oaron.su" },
                new User { Email = "paron@paron.su" },
                new User { Email = "qaron@qaron.su" },
                new User { Email = "raron@raron.su" },
                new User { Email = "saron@saron.su" },
                new User { Email = "taron@taron.su" },
                new User { Email = "uaron@uaron.su" },
                new User { Email = "varon@varon.su" },
                new User { Email = "aoron@aaron.su" },
                new User { Email = "boron@baron.su" },
                new User { Email = "coron@caron.su" },
                new User { Email = "doron@daron.su" },
                new User { Email = "eoron@earon.su" },
                new User { Email = "foron@faron.su" },
                new User { Email = "goron@garon.su" },
                new User { Email = "horon@haron.su" },
                new User { Email = "ioron@iaron.su" },
                new User { Email = "joron@jaron.su" },
                new User { Email = "koron@karon.su" },
                new User { Email = "loron@laron.su" },
                new User { Email = "moron@maron.su" },
                new User { Email = "noron@naron.su" },
                new User { Email = "ooron@oaron.su" },
                new User { Email = "poron@paron.su" },
                new User { Email = "qoron@qaron.su" },
                new User { Email = "roron@raron.su" },
                new User { Email = "soron@saron.su" },
                new User { Email = "toron@taron.su" },
                new User { Email = "uoron@uaron.su" },
                new User { Email = "voron@varon.su" }
                
            };

            foreach (var temp in users)
            {
                context.Users.Add(temp);
            }

            context.SaveChanges();

            int UserNo = 1;
            //declaring and saving products
            var preferences = new List<Preference>
            {
                
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Watch", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Shoes", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Jewelery", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Hat", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Ring", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Diamonds", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Cash", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Watch", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Shoes", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Jewelery", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Hat", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Ring", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Diamonds", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Cash", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Watch", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Shoes", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Jewelery", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Hat", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Ring", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Diamonds", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Watch", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Shoes", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Jewelery", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Hat", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Ring", Flowers = true, UserId = UserNo++},
                new Preference { Occasions = Occasionals.Birthday, UserPreference = "Diamonds", Flowers = true, UserId = UserNo++}
               
            };

            foreach (var temp in preferences)
            {
                context.Preferences.Add(temp);
            }

            context.SaveChanges();

        }

    }
}