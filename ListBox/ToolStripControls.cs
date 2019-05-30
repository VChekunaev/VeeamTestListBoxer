using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string pString = string.Join(",",resultlistBox.Items.Cast<string>());
            byte[] byteArray = Encoding.Default.GetBytes(pString);
            Crypto.EncryptAndSave(byteArray, saveFileDialog.FileName, chyperPass);
        }
        private void ContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "./LixtBoxer.chm", HelpNavigator.TableOfContents);
        }
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resultlistBox.SelectedItem != null)
            {
                Clipboard.SetText(resultlistBox.Items.Cast<string>().ToList().Find(x => x == resultlistBox.SelectedItem.ToString()));
                Worker.UndoBufferedLines = Worker.BufferedLines;
                Worker.BufferedLines.Remove(resultlistBox.SelectedItem.ToString());
                resultlistBox.Items.Remove(resultlistBox.SelectedItem.ToString());
            }
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resultlistBox.SelectedItem != null)
                Clipboard.SetText(resultlistBox.SelectedItem.ToString());
        }
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string buffer = Clipboard.GetText();
                bool condtition = buffer.Length <= 8 && Regex.IsMatch(buffer, "(\\d+|[a-zA-Z]+)");
                if (condtition)
                {
                    resultlistBox.Items.Add(buffer);
                    Worker.UndoBufferedLines = Worker.BufferedLines;
                    Worker.BufferedLines.Add(buffer);
                }
                else
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Your are trying to add an invalid value from clipboard.", "Incorect value in buffer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worker.BufferedLines = Worker.UndoBufferedLines;
            Worker.UndoBufferedLines.Clear();
            LineReloads();
        }
    }
}
