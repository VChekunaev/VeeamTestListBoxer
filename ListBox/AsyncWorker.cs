using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ListBoxer
{
    public partial class ListBoxer
    {
        private async void RecordsChecker()
        {
            while (true)
            {
                await Task.Delay(1);
                recordLabel.Text = $"Records in List: {resultlistBox.Items.Count}";
                totalLabel.Text = $"Total records: {Worker.BufferedLines.Count()}";
            }
        }
        private async void ClearEnabledChecker()
        {
            while (true)
            {
                await Task.Delay(1);
                clearButton.Enabled = Worker.BufferedLines.Count > 0;
            }
        }
        private async void UndoEnabledCheker()
        {
            while (true)
            {
                await Task.Delay(1);
                undoToolStripMenuItem.Enabled = Worker.UndoBufferedLines.Count > 0;
            }
        }
        private async void PasteEnabledChecker()
        {
            while (true)
            {
                try
                {
                    await Task.Delay(1);
                    string buffer = Clipboard.GetText();
                    bool condtition = buffer.Length <= 8 && Regex.IsMatch(buffer, "(\\d+|[a-zA-Z]+)");
                    if (condtition)
                        pasteToolStripMenuItem.Enabled = true;
                    else
                        pasteToolStripMenuItem.Enabled = false;
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
