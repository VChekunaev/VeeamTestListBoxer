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
        public static byte[] FileEncryptor(string[] lines, SymmetricAlgorithm algorithm, byte[] rgbKey, byte[] rgbIV)
        {
            //if (string.IsNullOrEmpty(fileIn))
            //   throw new FileNotFoundException(string.Format("Неверный путь к файлу: {0}.", fileIn));
            //if (!File.Exists(fileIn))
            //    throw new FileNotFoundException(string.Format("Файл '{0}' не найден.", fileIn));

            byte[] buffer = null;
            using (MemoryStream stream = new MemoryStream())
            {
                using (SymmetricAlgorithm sa = algorithm)
                {
                    using (CryptoStream cs = new CryptoStream(stream, sa.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write))
                    {
                        using (var streamWriter = new StreamWriter(cs))
                        {
                            foreach (string line in lines)
                                streamWriter.WriteLine(line);
                        }
                    }
                }
                buffer = stream.ToArray();
            }
            return buffer;
        }
    }
}



