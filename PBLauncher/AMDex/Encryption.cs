using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBLauncher.AMDex
{
    public class Encryption
    {
        public string EncryptBase64(string plaintext)
        {
            byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
            return Convert.ToBase64String(plaintextBytes);
        }

        public string DecryptBase64(string ciphertext)
        {
            byte[] ciphertextBytes = Convert.FromBase64String(ciphertext);
            return Encoding.UTF8.GetString(ciphertextBytes);
        }
    }
}
