using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AuthenticationTestApp.Core.Authentication.Database
{
    //Similar to "DbContext", it provides mapping to Identity Tables in SQLSERVER
    public class AuthDbContext : IdentityDbContext<IdentityUser>
    {
        public AuthDbContext()
            : base("AuthDbContext")
        {

        }
    }
}
