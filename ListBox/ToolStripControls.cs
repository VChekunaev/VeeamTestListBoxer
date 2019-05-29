using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace ListBoxer
{
    public partial class ListBoxer
    {
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string lbxDir = Path.Combine(Application.StartupPath, "lbx");
            if (!Directory.Exists(lbxDir))
                Directory.CreateDirectory(lbxDir);
            saveFileDialog.InitialDirectory = lbxDir;
            saveFileDialog.ShowDialog();
            string saveFile = saveFileDialog.FileName;


            using (var fs = File.Open(saveFile, FileMode.OpenOrCreate, FileAccess.Write))
            using (var aes = new AesCryptoServiceProvider())
            {
                var rnd = RandomNumberGenerator.Create();
                byte[] rgbKey = new byte[aes.KeySize / 8],
                       rgbIV = new byte[16];

                rnd.GetNonZeroBytes(rgbKey);
                rnd.GetNonZeroBytes(rgbIV);

                byte[] encbuff = Crypto.FileEncryptor(resultTextBox.Lines, aes, rgbKey, rgbIV);

                fs.Write(rgbKey, 0, rgbKey.Length);
                fs.Write(rgbIV, 0, rgbIV.Length);
                fs.Write(encbuff, 0, encbuff.Length);
            }
        }

        private void ContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "./LixtBoxer.chm", HelpNavigator.TableOfContents);
        }

    }
}
