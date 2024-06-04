using System.Security.Cryptography;
using System.Text;

namespace Project.Data
{
    public static class Cryptographer
    {
        public static string Encrypt(string pass)
        {
            var md5 = MD5.Create();
            var HashMd5 = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
            var sha = SHA1.Create();
            var HashSha = sha.ComputeHash(Encoding.UTF8.GetBytes(pass));
            var hash = Convert.ToBase64String(HashMd5) + Convert.ToBase64String(HashSha);
            return hash;
        }
    }
}
