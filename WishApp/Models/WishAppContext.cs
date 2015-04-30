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

        public DbSet<User> Users { get; set; }

        public DbSet<Preference> Preferences { get; set; }

    }
}