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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SubtotalWorkingMinutesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workingDaysTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalOrMissingMinutesTextbox = new System.Windows.Forms.TextBox();
            this.workingMinutesTextBox = new System.Windows.Forms.TextBox();
            this.TotalResultTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.SubtotalWorkingMinutesTextBox);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.workingDaysTextBox);
            this.tabPage2.Controls.Add(this.AdditionalOrMissingMinutesTextbox);
            this.tabPage2.Controls.Add(this.workingMinutesTextBox);
            this.tabPage2.Controls.Add(this.TotalResultTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add/Subtract";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subtotal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SubtotalWorkingMinutesTextBox
            // 
            this.SubtotalWorkingMinutesTextBox.Location = new System.Drawing.Point(104, 224);
            this.SubtotalWorkingMinutesTextBox.Name = "SubtotalWorkingMinutesTextBox";
            this.SubtotalWorkingMinutesTextBox.Size = new System.Drawing.Size(125, 27);
            this.SubtotalWorkingMinutesTextBox.TabIndex = 9;
            this.SubtotalWorkingMinutesTextBox.TextChanged += new System.EventHandler(this.SubtotalWorkingMinutes_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Count!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TOTAL RESULT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Additional +/-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "x 480 minutes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type the amount of working days";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // workingDaysTextBox
            // 
            this.workingDaysTextBox.Location = new System.Drawing.Point(104, 64);
            this.workingDaysTextBox.Name = "workingDaysTextBox";
            this.workingDaysTextBox.Size = new System.Drawing.Size(242, 27);
            this.workingDaysTextBox.TabIndex = 3;
            // 
            // AdditionalOrMissingMinutesTextbox
            // 
            this.AdditionalOrMissingMinutesTextbox.Location = new System.Drawing.Point(107, 316);
            this.AdditionalOrMissingMinutesTextbox.Name = "AdditionalOrMissingMinutesTextbox";
            this.AdditionalOrMissingMinutesTextbox.Size = new System.Drawing.Size(125, 27);
            this.AdditionalOrMissingMinutesTextbox.TabIndex = 2;
            this.AdditionalOrMissingMinutesTextbox.TextChanged += new System.EventHandler(this.AdditionalOrMissingMinutesTextbox_TextChanged);
            // 
            // workingMinutesTextBox
            // 
            this.workingMinutesTextBox.Location = new System.Drawing.Point(107, 134);
            this.workingMinutesTextBox.Name = "workingMinutesTextBox";
            this.workingMinutesTextBox.Size = new System.Drawing.Size(68, 27);
            this.workingMinutesTextBox.TabIndex = 1;
            this.workingMinutesTextBox.Text = "480";
            // 
            // TotalResultTextBox
            // 
            this.TotalResultTextBox.Location = new System.Drawing.Point(104, 385);
            this.TotalResultTextBox.Name = "TotalResultTextBox";
            this.TotalResultTextBox.Size = new System.Drawing.Size(125, 27);
            this.TotalResultTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 488);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
    }
}