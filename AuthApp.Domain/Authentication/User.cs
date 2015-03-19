using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthApp.Domain.Authentication
{
    public class UserModel
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }
    }
}
