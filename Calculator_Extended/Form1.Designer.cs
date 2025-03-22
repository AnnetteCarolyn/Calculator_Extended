namespace Calculator_Extended
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            tabPage2 = new TabPage();
            button2 = new Button();
            label5 = new Label();
            SubtotalWorkingMinutesTextBox = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            workingDaysTextBox = new TextBox();
            AdditionalOrMissingMinutesTextbox = new TextBox();
            workingMinutesTextBox = new TextBox();
            TotalResultTextBox = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(10, 2);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(720, 353);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(712, 325);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 98);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(36, 52);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            numericUpDown1.KeyUp += numericUpDown1_KeyUp;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 25);
            label6.Name = "label6";
            label6.Size = new Size(199, 15);
            label6.TabIndex = 5;
            label6.Text = "Choose the amount of working days";
            label6.Click += label6_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(SubtotalWorkingMinutesTextBox);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(workingDaysTextBox);
            tabPage2.Controls.Add(AdditionalOrMissingMinutesTextbox);
            tabPage2.Controls.Add(workingMinutesTextBox);
            tabPage2.Controls.Add(TotalResultTextBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(712, 325);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(339, 230);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(111, 22);
            button2.TabIndex = 11;
            button2.Text = "Add/Subtract";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 138);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Subtotal";
            // 
            // SubtotalWorkingMinutesTextBox
            // 
            SubtotalWorkingMinutesTextBox.Location = new Point(91, 168);
            SubtotalWorkingMinutesTextBox.Margin = new Padding(3, 2, 3, 2);
            SubtotalWorkingMinutesTextBox.Name = "SubtotalWorkingMinutesTextBox";
            SubtotalWorkingMinutesTextBox.Size = new Size(110, 23);
            SubtotalWorkingMinutesTextBox.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(221, 169);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 8;
            button1.Text = "Count!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 260);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 7;
            label4.Text = "TOTAL RESULT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 212);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 6;
            label3.Text = "Additional +/-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 83);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 5;
            label2.Text = "x 480 minutes";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 21);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 4;
            label1.Text = "Type the amount of working days";
            label1.Click += label1_Click;
            // 
            // workingDaysTextBox
            // 
            workingDaysTextBox.Location = new Point(91, 48);
            workingDaysTextBox.Margin = new Padding(3, 2, 3, 2);
            workingDaysTextBox.Name = "workingDaysTextBox";
            workingDaysTextBox.Size = new Size(212, 23);
            workingDaysTextBox.TabIndex = 3;
            // 
            // AdditionalOrMissingMinutesTextbox
            // 
            AdditionalOrMissingMinutesTextbox.Location = new Point(94, 229);
            AdditionalOrMissingMinutesTextbox.Margin = new Padding(3, 2, 3, 2);
            AdditionalOrMissingMinutesTextbox.Name = "AdditionalOrMissingMinutesTextbox";
            AdditionalOrMissingMinutesTextbox.Size = new Size(239, 23);
            AdditionalOrMissingMinutesTextbox.TabIndex = 2;
            // 
            // workingMinutesTextBox
            // 
            workingMinutesTextBox.Location = new Point(94, 100);
            workingMinutesTextBox.Margin = new Padding(3, 2, 3, 2);
            workingMinutesTextBox.Name = "workingMinutesTextBox";
            workingMinutesTextBox.Size = new Size(60, 23);
            workingMinutesTextBox.TabIndex = 1;
            workingMinutesTextBox.Text = "480";
            // 
            // TotalResultTextBox
            // 
            TotalResultTextBox.Location = new Point(91, 289);
            TotalResultTextBox.Margin = new Padding(3, 2, 3, 2);
            TotalResultTextBox.Name = "TotalResultTextBox";
            TotalResultTextBox.Size = new Size(110, 23);
            TotalResultTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 366);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox workingDaysTextBox;
        private TextBox AdditionalOrMissingMinutesTextbox;
        private TextBox workingMinutesTextBox;
        private TextBox TotalResultTextBox;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox SubtotalWorkingMinutesTextBox;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private TextBox textBox1;
    }
}