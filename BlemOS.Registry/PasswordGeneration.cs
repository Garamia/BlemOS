using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlemOS.Registry
{
    /// <summary>
    /// A class to generate passwords
    /// </summary>
    public static class PasswordGeneration
    {

        public static byte[] GenerateSalt(int length)
        {
            //create a new byte array
            byte[] bytes = new byte[length];

            //User the rngcrypteserviceprovider to generate a salt
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }

            return bytes;
        }
        static byte[] GenerateHash(byte[] password, byte[] salt, int iterations, int length)
        {
            //Create a new hash using the given password, salt, and iterations
            using (Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                return deriveBytes.GetBytes(length);
            }
        }

        public static byte[] EncryptPassword(string password, byte[] salt)
        {
            //Get the bytes from the password and generate an encrypted hash
            byte[] pass = Encoding.ASCII.GetBytes(password);
            return GenerateHash(pass, salt, 10, 10);
        }
    }
}
