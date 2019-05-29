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
        public string LbxDir { get; set; } = Path.Combine(Application.StartupPath, "lbx");
        private const string chyperPass = "password";
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = LbxDir;
            openFileDialog.ShowDialog();

            Crypto.LoadAndDecrypt(File.Open(openFileDialog.FileName, FileMode.Open), chyperPass);
            LineReloads();
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = LbxDir;
            saveFileDialog.ShowDialog();

            byte[] byteArray = Encoding.Default.GetBytes(resultTextBox.Text);
            Crypto.EncryptAndSave(byteArray, saveFileDialog.FileName, chyperPass);
        }

        private void ContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "./LixtBoxer.chm", HelpNavigator.TableOfContents);
        }

    }
}
