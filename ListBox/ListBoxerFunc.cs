using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxer
{
    public static class ListBoxerFunc
    {
        public static void LoadAndDecrypt(FileStream file, string password)
        {
            using (var cypher = new AesManaged())
            using (var fsIn = file)
            using (var fsOut = new MemoryStream())
            {
                const int saltLength = 256;
                var salt = new byte[saltLength];
                var iv = new byte[cypher.BlockSize / 8];

                    fsIn.Read(salt, 0, saltLength);
                    fsIn.Read(iv, 0, iv.Length);

                var pdb = new Rfc2898DeriveBytes(password, salt);
                var key = pdb.GetBytes(cypher.KeySize / 8);

                using (ICryptoTransform cryptoTransform = cypher.CreateDecryptor(key, iv))
                using (CryptoStream cs = new CryptoStream(fsOut, cryptoTransform, CryptoStreamMode.Write))
                {
                    fsIn.CopyTo(cs);
                }
                ListBoxer.BufferedLines = Encoding.Default.GetString(fsOut.ToArray()).Split(',').ToList();
            }

        }
        public static void EncryptAndSave(byte[] input, string outputPath, string password)
        {
            using (var cypher = new AesManaged())
            using (MemoryStream fsIn = new MemoryStream(input))
            using (var fsOut = new FileStream(outputPath, FileMode.Create))
            {
                const int saltLength = 256;
                var salt = new byte[saltLength];
                var iv = new byte[cypher.BlockSize / 8];

                    using (var rng = new RNGCryptoServiceProvider())
                    {
                        rng.GetBytes(salt);
                        rng.GetBytes(iv);
                    }
                    fsOut.Write(salt, 0, salt.Length);
                    fsOut.Write(iv, 0, iv.Length);

                var pdb = new Rfc2898DeriveBytes(password, salt);
                var key = pdb.GetBytes(cypher.KeySize / 8);

                using (ICryptoTransform cryptoTransform = cypher.CreateEncryptor(key, iv))
                using (CryptoStream cs = new CryptoStream(fsOut, cryptoTransform, CryptoStreamMode.Write))
                {
                    fsIn.CopyTo(cs);
                }
            }
        }
        public static bool IsBetween<T>(this T item, T start, T end)
        {
            return Comparer<T>.Default.Compare(item, start) >= 0 && Comparer<T>.Default.Compare(item, end) <= 0;
        }
    }
}



