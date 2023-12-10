using System.Text;
using System.Security.Cryptography;
namespace Utilities.Library.Utilities
{
    public static class Utils
    {
        public static string cifrarCadena(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert the password string to a byte array
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Compute the hash value of the byte array
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                // Convert the hashed byte array to a string representation
                string hashedPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                return hashedPassword;
            }
        }
    }
}
