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
        public static List<string> UndoBufferedLines { get; set; } = new List<string>(0);
        public static List<string> BufferedLines { get; set; } = new List<string>(0);

        public ListBoxer() => InitializeComponent();
        private void ListBoxer_Load(object sender, EventArgs e)
        {
            RecordsChecker();
            ClearEnabledChecker();
            UndoEnabledCheker();
            PasteEnabledChecker();
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
                else if (checkBox_aplhabetic.Checked && Regex.IsMatch(inputTextBox.Text, "[a-zA-z]"))
                {
                    UndoBufferedLines.Clear();
                    UndoBufferedLines.AddRange(BufferedLines.Select(x => x).ToList());
                    BufferedLines.Add(inputTextBox.Text == "0" ? inputTextBox.Text : inputTextBox.Text.TrimStart('0', ' '));
                }
                else if (checkBox_numeric.Checked && Regex.IsMatch(inputTextBox.Text, "[0-9]") && Convert.ToInt32(inputTextBox.Text).IsBetween(0,9999))
                {
                    UndoBufferedLines.Clear();
                    UndoBufferedLines.AddRange(BufferedLines.Select(x => x).ToList());
                    BufferedLines.Add(inputTextBox.Text == "0" ? inputTextBox.Text : inputTextBox.Text.TrimStart('0', ' '));
                }
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
            BufferedLines.Clear();
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
                             BufferedLines.Where(x => !Regex.IsMatch(inputTextBox.Text, "[0-9]"))
                            .Where(fltr => fltr.ToLower()[0] >= 'a' && fltr.ToLower()[0] <= 'm').ToList();
                        break;
                    case "Nn-Zz":
                        result =
                             BufferedLines.Where(x => !Regex.IsMatch(inputTextBox.Text, "[0-9]"))
                            .Where(fltr => fltr.ToLower()[0] >= 'n' && fltr.ToLower()[0] <= 'z').ToList();
                        break;
                    case "0-100":
                        result =
                             BufferedLines.Where(x => !Regex.IsMatch(x, "[a-zA-z]"))
                            .Where(fltr => Convert.ToInt32(fltr) >= 0 && Convert.ToInt32(fltr) <= 100).ToList();
                        break;
                    case "101-200":
                        result =
                             BufferedLines.Where(x => !Regex.IsMatch(x, "[a-zA-z]"))
                            .Where(fltr => Convert.ToInt32(fltr) >= 101 && Convert.ToInt32(fltr) <= 200).ToList();
                        break;
                    case "201-300":
                        result =
                             BufferedLines.Where(x => !Regex.IsMatch(x, "[a-zA-z]"))
                            .Where(fltr => Convert.ToInt32(fltr) >= 201 && Convert.ToInt32(fltr) <= 300).ToList();
                        break;
                    case "301-9999":
                        result =
                             BufferedLines.Where(x => !Regex.IsMatch(x, "[a-zA-z]"))
                            .Where(fltr => Convert.ToInt32(fltr) >= 301 && Convert.ToInt32(fltr) <= 9999).ToList();
                        break;
                    case "All":
                        if (checkBox_aplhabetic.Checked && !checkBox_numeric.Checked)
                            result =
                                 BufferedLines.Where(x => !Regex.IsMatch(inputTextBox.Text, "[1-9]"))
                                .Where(fltr => fltr.ToLower()[0] >= 'a' && fltr.ToLower()[0] <= 'z').ToList();
                        if (!checkBox_aplhabetic.Checked && checkBox_numeric.Checked)
                            result =
                                 BufferedLines.Where(x => !Regex.IsMatch(x, "[a-zA-z]"))
                                .Where(fltr => Convert.ToInt32(fltr) >= 0 && Convert.ToInt32(fltr) <= 9999).ToList();
                        if (checkBox_aplhabetic.Checked && checkBox_numeric.Checked)
                            result =
                                 BufferedLines;
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
            var temp = resultlistBox.Items.Cast<string>().OrderBy(x => x).ToArray();
            resultlistBox.Items.Clear();
            resultlistBox.Items.AddRange(temp);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var temp = resultlistBox.Items.Cast<string>().OrderByDescending(x => x).ToArray();
            resultlistBox.Items.Clear();
            resultlistBox.Items.AddRange(temp);
        }

        private void ListBoxer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton.PerformClick();
            }
        }

    }
}
