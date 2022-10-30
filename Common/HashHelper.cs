using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Common
{
    public static class HashHelper
    {
        public static string GetHash(string input)
        {
            using(var sha = SHA256.Create())
            {
                var data = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();
                foreach(var c in data)
                {
                    sb.Append(c.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public static bool Verify(string input, string hash)
        {
            var comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hash, GetHash(input)) == 0;
        }
    }
}