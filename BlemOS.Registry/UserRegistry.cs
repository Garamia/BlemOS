using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlemOS.Registry
{
    /// <summary>
    /// The Registry for all User Related Functions
    /// </summary>
    public static class UserRegistry
    {
        public static bool addUser(string username, string password)
        {
            //Loop through the Users in the Persistent Settings to see if this user already exists
            foreach (UserObject uo in PersistentSettings.internalSettings.Users)
            {
                //If the user exists, exit and return with an error
                if (uo.Username == username) return false;
            }

            //Generatate a Salt to encrypt the password and encrypt the password
            byte[] salt = PasswordGeneration.GenerateSalt(50);
            byte[] encryptedPassword = PasswordGeneration.EncryptPassword(password, salt);

            //Conver the byte arrays into base64 strings for storage
            string base64Password = Convert.ToBase64String(encryptedPassword);
            string base64Salt = Convert.ToBase64String(salt);

            //Create a User Object and Store it.
            UserObject user = new UserObject(username, base64Password, base64Salt);
            PersistentSettings.internalSettings.Users.Add(user);
            PersistentSettings.update();
            return true;
        }

        public static bool checkPassword(string username, string password)
        {
            //Loop through all of the users
            foreach (UserObject user in PersistentSettings.internalSettings.Users)
            {
                //If the user is not the one we are looking for, continue to the next iteration
                if (user.Username != username) continue;

                //Encrypt the password given to check and the password of the user
                byte[] encrypted = PasswordGeneration.EncryptPassword(password, Convert.FromBase64String(user.Salt));
                byte[] userhash = Convert.FromBase64String(user.PasswordHash);

                //Check if the given and stored are equal
                if (userhash.SequenceEqual(encrypted))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //If we can't find the user, return with false
            return false;
        }
    }
}
