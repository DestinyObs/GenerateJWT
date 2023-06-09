using System;
using System.Security.Cryptography;

namespace JwtSecretKeyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var secretKey = GenerateSecretKey();
            Console.WriteLine(secretKey);
        }

        private static string GenerateSecretKey()
        {
            var randomBytes = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes);
        }
    }
}
