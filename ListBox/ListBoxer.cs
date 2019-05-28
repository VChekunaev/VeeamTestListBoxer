using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxer
{
    public partial class ListBoxer : Form
    {
        public ListBoxer()
        {
            InitializeComponent();
        }

        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            switch(checkBox_aplhabetic.Checked || checkBox_numeric.Checked)
            {
                case false:
                    comboBox1.Items.Add("<none>");
                    break;
                case true:
                    comboBox1.Items.Add("All");
                    if (checkBox_aplhabetic.Checked)
                        comboBox1.Items.AddRange(items: new string[] { "Aa-Mm", "Nn-Zz" });
                    if (checkBox_numeric.Checked)
                        comboBox1.Items.AddRange(items: new string[] { "0-100", "101-200", "201-300", "301-9999" });
                    break;
            }
        }

        private void Text_Appear(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "")
                clearButton.Enabled = false;
            else
                clearButton.Enabled = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            resultTextBox.AppendLine(inputTextBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
        }

        private void ListBoxer_Load(object sender, EventArgs e)
        {

        }
    }
}
