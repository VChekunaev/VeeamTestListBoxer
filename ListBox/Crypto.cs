using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxer
{
    public static class Crypto
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
                Worker.BufferedLines = Encoding.Default.GetString(fsOut.ToArray()).Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();
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
    }
}



