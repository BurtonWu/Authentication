using AuthenticationTestApp.Core.Authentication.Database;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthApp.Core.Authentication.Server
{
    public class AuthRepository
    {
        private AuthDbContext _authDbContext;
        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _authDbContext = new AuthDbContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_authDbContext));
        }

        //public async Task<IdentityResult> RegisterUser(UserModel)
    }
}
