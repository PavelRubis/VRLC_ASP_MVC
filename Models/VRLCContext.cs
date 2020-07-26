using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebSiteASP.Models
{
    public class VRLCContext : DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}