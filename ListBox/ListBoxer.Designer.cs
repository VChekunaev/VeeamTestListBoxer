namespace ListBoxer
{
    partial class ListBoxer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBoxer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_numeric = new System.Windows.Forms.CheckBox();
            this.checkBox_aplhabetic = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descendingRadioButton = new System.Windows.Forms.RadioButton();
            this.ascendingRadioButton = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.recordLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_numeric);
            this.groupBox1.Controls.Add(this.checkBox_aplhabetic);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Symbols";
            // 
            // checkBox_numeric
            // 
            this.checkBox_numeric.AutoSize = true;
            this.checkBox_numeric.Location = new System.Drawing.Point(7, 46);
            this.checkBox_numeric.Name = "checkBox_numeric";
            this.checkBox_numeric.Size = new System.Drawing.Size(65, 17);
            this.checkBox_numeric.TabIndex = 1;
            this.checkBox_numeric.Text = "Numeric";
            this.checkBox_numeric.UseVisualStyleBackColor = true;
            // 
            // checkBox_aplhabetic
            // 
            this.checkBox_aplhabetic.AutoSize = true;
            this.checkBox_aplhabetic.Location = new System.Drawing.Point(7, 20);
            this.checkBox_aplhabetic.Name = "checkBox_aplhabetic";
            this.checkBox_aplhabetic.Size = new System.Drawing.Size(76, 17);
            this.checkBox_aplhabetic.TabIndex = 0;
            this.checkBox_aplhabetic.Text = "Alphabetic";
            this.checkBox_aplhabetic.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.descendingRadioButton);
            this.groupBox2.Controls.Add(this.ascendingRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 87);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort Order";
            // 
            // descendingRadioButton
            // 
            this.descendingRadioButton.AutoSize = true;
            this.descendingRadioButton.Location = new System.Drawing.Point(7, 43);
            this.descendingRadioButton.Name = "descendingRadioButton";
            this.descendingRadioButton.Size = new System.Drawing.Size(82, 17);
            this.descendingRadioButton.TabIndex = 1;
            this.descendingRadioButton.TabStop = true;
            this.descendingRadioButton.Text = "Descending";
            this.descendingRadioButton.UseVisualStyleBackColor = true;
            this.descendingRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // ascendingRadioButton
            // 
            this.ascendingRadioButton.AutoSize = true;
            this.ascendingRadioButton.Location = new System.Drawing.Point(7, 20);
            this.ascendingRadioButton.Name = "ascendingRadioButton";
            this.ascendingRadioButton.Size = new System.Drawing.Size(75, 17);
            this.ascendingRadioButton.TabIndex = 0;
            this.ascendingRadioButton.TabStop = true;
            this.ascendingRadioButton.Text = "Ascending";
            this.ascendingRadioButton.UseVisualStyleBackColor = true;
            this.ascendingRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "<none>";
            this.comboBox1.DropDown += new System.EventHandler(this.ComboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Range";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(218, 29);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(156, 20);
            this.inputTextBox.TabIndex = 8;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(218, 55);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(156, 181);
            this.resultTextBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(381, 25);
            this.addButton.Name = "addButton";
            this.helpProvider.SetShowHelp(this.addButton, true);
            this.addButton.Size = new System.Drawing.Size(104, 44);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add to List";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(381, 75);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 44);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear List";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Location = new System.Drawing.Point(381, 196);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(37, 13);
            this.recordLabel.TabIndex = 12;
            this.recordLabel.Text = "record";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(381, 223);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(27, 13);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "total";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(497, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // открытьToolStripButton
            // 
            this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.открытьToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.открытьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton.Image")));
            this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton.Name = "открытьToolStripButton";
            this.открытьToolStripButton.ShowDropDownArrow = false;
            this.открытьToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.открытьToolStripButton.Text = "&File";
            this.открытьToolStripButton.ToolTipText = "File123";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.сохранитьToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.ShowDropDownArrow = false;
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(31, 22);
            this.сохранитьToolStripButton.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.ShowDropDownArrow = false;
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.contentsToolStripMenuItem.Text = "Contents...";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.ContentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "lbx";
            this.openFileDialog.Filter = "Database File | *.lbx";
            this.openFileDialog.InitialDirectory = "./lbx/";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "lbx";
            this.saveFileDialog.Filter = "Database File | *.lbx";
            // 
            // ListBoxer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 248);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListBoxer";
            this.Text = "ListBoxer";
            this.Load += new System.EventHandler(this.ListBoxer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox checkBox_numeric;
        private System.Windows.Forms.CheckBox checkBox_aplhabetic;
        private System.Windows.Forms.RadioButton descendingRadioButton;
        private System.Windows.Forms.RadioButton ascendingRadioButton;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton открытьToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton сохранитьToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

