using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WishApp.Models
{
    public class WishAppContext : DbContext
    {
        public WishAppContext() : base("name=WishAppContext")
        {
        }

        //User database table
        public DbSet<User> Users { get; set; }

        //Preference database table
        public DbSet<Preference> Preferences { get; set; }
    
    }
}
