﻿namespace ListBoxer
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // ListBoxer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 248);
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
    }
}

