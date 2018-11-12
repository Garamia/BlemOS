using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlemOS.Registry
{
    public static class UserRegistry
    {
        public static bool addUser(string username, string password)
        {
            foreach (UserObject uo in PersistentSettings.internalSettings.Users)
            {
                if (uo.Username == username) return false;
            }

            byte[] salt = PasswordRegistry.GenerateSalt(50);
            byte[] encryptedPassword = PasswordRegistry.EncryptPassword(password, salt);

            PersistentSettings.internalSettings.Users.Add(new UserObject(username, Convert.ToBase64String(encryptedPassword), Convert.ToBase64String(salt)));
            PersistentSettings.update();
            return true;
        }

        public static bool checkPassword(string username, string password)
        {
            foreach (UserObject user in PersistentSettings.internalSettings.Users)
            {
                if(user.Username == username)
                {
                    byte[] encrypted = PasswordRegistry.EncryptPassword(password, Convert.FromBase64String(user.Salt));
                    byte[] userhash = Convert.FromBase64String(user.PasswordHash);
                    if (userhash.SequenceEqual(encrypted))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
                }
            }
            return false;
        }
    }
}
