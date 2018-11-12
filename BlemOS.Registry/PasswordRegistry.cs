using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlemOS.Registry
{
    public static class PasswordRegistry
    {

        public static byte[] GenerateSalt(int length)
        {
            var bytes = new byte[length];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }

            return bytes;
        }
        static byte[] GenerateHash(byte[] password, byte[] salt, int iterations, int length)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                return deriveBytes.GetBytes(length);
            }
        }

        public static byte[] EncryptPassword(string password, byte[] salt)
        {
            byte[] pass = Encoding.ASCII.GetBytes(password);
            return GenerateHash(pass, salt, 10, 10);
        }
    }
}
