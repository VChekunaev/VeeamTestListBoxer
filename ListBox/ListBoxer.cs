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
    public partial class ListBoxer : Form
    {

        public ListBoxer() => InitializeComponent();
        private void ListBoxer_Load(object sender, EventArgs e)
        {
            RecordsChecker();
            clearButton.CheckBufferedLines();
            if (!Directory.Exists(LbxDir)) Directory.CreateDirectory(LbxDir);
        }
        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("<none>");
            if (checkBox_aplhabetic.Checked || checkBox_numeric.Checked)
            {
                comboBox1.Items.Add("All");
                if (checkBox_aplhabetic.Checked)
                    comboBox1.Items.AddRange(items: new string[] { "Aa-Mm", "Nn-Zz" });
                if (checkBox_numeric.Checked)
                    comboBox1.Items.AddRange(items: new string[] { "0-100", "101-200", "201-300", "301-9999" });
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputTextBox.Text.Length == 0)
                    throw new Exception();
                else if (checkBox_aplhabetic.Checked && Regex.IsMatch(inputTextBox.Text, "[1-9]"))
                    Worker.BufferedLines.Add(inputTextBox.Text == "0" ? inputTextBox.Text : inputTextBox.Text.TrimStart('0', ' '));
                else if (checkBox_numeric.Checked && Regex.IsMatch(inputTextBox.Text, "[a-zA-z]"))
                    Worker.BufferedLines.Add(inputTextBox.Text == "0" ? inputTextBox.Text : inputTextBox.Text.TrimStart('0', ' '));
                else
                    throw new Exception();
                inputTextBox.Text = "";
                LineReloads();
            }
            catch
            {
                MessageBox.Show("Your are trying to add an invalid string", "Incorect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Worker.BufferedLines.Clear();
            LineReloads();
        }
        private void LineReloads()
        {
            resultlistBox.Items.Clear();
            IEnumerable<string> result = new List<string>();
            if (checkBox_aplhabetic.Checked || checkBox_numeric.Checked)
            {
                switch (comboBox1.Text)
                {
                    case "Aa-Mm":
                        result =
                             Worker.BufferedLines
                            .Where(x => !Regex.IsMatch(inputTextBox.Text, "[1-9]"))
                            .Where(fltr => fltr.ToLower()[0] >= 'a' && fltr.ToLower()[0] <= 'm').ToList();
                        break;
                    case "Nn-Zz":
                        result =
                             Worker.BufferedLines
                            .Where(x => !Regex.IsMatch(inputTextBox.Text, "[1-9]"))
                            .Where(fltr => fltr.ToLower()[0] >= 'n' && fltr.ToLower()[0] <= 'z').ToList();
                        break;
                    case "0-100":
                        result =
                             Worker.BufferedLines
                            .Where(x => !Regex.IsMatch(x, "[a-zA-z]"))
                            .Where(fltr => Convert.ToInt32(fltr) >= 0 && Convert.ToInt32(fltr) <= 100).ToList();
                        break;
                    case "101-200":
                        result =
                             Worker.BufferedLines
                            .Where(x => !Regex.IsMatch(x, "[a-zA-z]"))
                            .Where(fltr => Convert.ToInt32(fltr) >= 101 && Convert.ToInt32(fltr) <= 200).ToList();
                        break;
                    case "201-300":
                        result =
                             Worker.BufferedLines
                            .Where(x => !Regex.IsMatch(x, "[a-zA-z]"))
                            .Where(fltr => Convert.ToInt32(fltr) >= 201 && Convert.ToInt32(fltr) <= 300).ToList();
                        break;
                    case "301-9999":
                        result =
                             Worker.BufferedLines
                            .Where(x => !Regex.IsMatch(x, "[a-zA-z]"))
                            .Where(fltr => Convert.ToInt32(fltr) >= 301 && Convert.ToInt32(fltr) <= 9999).ToList();
                        break;
                    case "All":
                        if (checkBox_aplhabetic.Checked && !checkBox_numeric.Checked)
                            result =
                                 Worker.BufferedLines
                                .Where(x => !Regex.IsMatch(inputTextBox.Text, "[1-9]"))
                                .Where(fltr => fltr.ToLower()[0] >= 'a' && fltr.ToLower()[0] <= 'z').ToList();
                        if (!checkBox_aplhabetic.Checked && checkBox_numeric.Checked)
                            result =
                                 Worker.BufferedLines
                                .Where(x => !Regex.IsMatch(x, "[a-zA-z]"))
                                .Where(fltr => Convert.ToInt32(fltr) >= 0 && Convert.ToInt32(fltr) <= 9999).ToList();
                        if (checkBox_aplhabetic.Checked && checkBox_numeric.Checked)
                            result = Worker.BufferedLines;
                        break;
                    default:
                        break;
                }
            }
            resultlistBox.Items.AddRange(result.ToArray());
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) => LineReloads();
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            resultlistBox.Items.Clear();
            resultlistBox.Items.AddRange(resultlistBox.Items.Cast<string>().OrderBy(x => x).ToArray());
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            resultlistBox.Items.Clear();
            resultlistBox.Items.AddRange(resultlistBox.Items.Cast<string>().OrderByDescending(x => x).ToArray());
        }

        private async void RecordsChecker()
        {
            while (true)
            {
                await Task.Delay(1);
                recordLabel.Text = $"Records in List: {resultlistBox.Items.Count}";
                totalLabel.Text = $"Total records: {Worker.BufferedLines.Count()}";
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resultlistBox.SelectedItem != null)
                Clipboard.SetText(resultlistBox.Items.Eject(resultlistBox.SelectedItem.ToString()));
        }
    }
}
