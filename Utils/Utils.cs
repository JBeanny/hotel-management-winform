using System.Security.Cryptography;
using System.Text;

namespace HotelManagement
{
    public static class Utils
    {
        public static string generateRandomId(int length, string prefix)
        {
            // Initialize the random number generator
            Random random = new Random();

            // Generate a random number with 5 digits
            int minLength = 10000; // Minimum value for a 5-digit number
            int maxLength = 99999; // Maximum value for a 5-digit number
            int randomNumber = random.Next(minLength, maxLength + 1);

            return prefix + randomNumber;
        }

        public static string hashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            string hashedEnteredPassword = hashPassword(enteredPassword);
            return hashedEnteredPassword == hashedPassword;
        }
    }
}
