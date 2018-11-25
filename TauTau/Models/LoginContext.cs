using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TauTau.Models
{
    public class LoginContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }
    }
}