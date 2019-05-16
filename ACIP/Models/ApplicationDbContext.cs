using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ACIP.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext():base("ACIPCONN")
        {

        }
        public DbSet<Login> logins { get; set; }

        public System.Data.Entity.DbSet<ACIP.Models.registration> registrations { get; set; }

        public System.Data.Entity.DbSet<ACIP.Models.LoginWithOutCredentials> LoginWithOutCredentials { get; set; }
    }
}