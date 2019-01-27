using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace BasicDoubleHashing
{
    class Crypto
    {
        public static string Sha256(string message)
        {
            SHA256Managed crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(message), 0, Encoding.ASCII.GetByteCount(message));
            foreach (byte theByte in crypto)
            {
                hash += Convert.ToString(theByte, 2).PadLeft(8, '0');
            }
            return hash;
        }

        public static string DoubleSha256(string message)
        {
            string hashVal = Sha256(message);
            return Sha256(hashVal);
        }

    }
}
