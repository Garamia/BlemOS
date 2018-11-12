using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlemOS.Registry
{
    public class UserObject
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }

        public UserObject(string Username, string PasswordHash, string Salt)
        {
            this.Username = Username;
            this.PasswordHash = PasswordHash;
            this.Salt = Salt;
        }
        
    }
}
