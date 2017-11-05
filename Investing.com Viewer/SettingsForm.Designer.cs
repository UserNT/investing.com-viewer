namespace Viewer
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filterIdsTextBox = new System.Windows.Forms.TextBox();
            this.filterIdsStartsWithTextBox = new System.Windows.Forms.TextBox();
            this.filterClassesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filterMessagesRadioButton = new System.Windows.Forms.RadioButton();
            this.filterMessagesInverseModeRadioButton = new System.Windows.Forms.RadioButton();
            this.filterMessagesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(553, 361);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(77, 19);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(533, 20);
            this.addressTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Home page:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterIdsStartsWithTextBox);
            this.groupBox2.Controls.Add(this.filterIdsTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 281);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove blocks by Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filterClassesTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(218, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 281);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remove blocks by Class";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.filterMessagesTextBox);
            this.groupBox4.Controls.Add(this.filterMessagesInverseModeRadioButton);
            this.groupBox4.Controls.Add(this.filterMessagesRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(428, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 281);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "1. Exact match by id, for example:\r\n<div id=\"ad\"...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(6, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "2. Match by id starts with, for example:\r\n<div id=\"ad-12345\"...\r\nwhere 12345 - dy" +
    "namic part";
            // 
            // filterIdsTextBox
            // 
            this.filterIdsTextBox.Location = new System.Drawing.Point(6, 55);
            this.filterIdsTextBox.Multiline = true;
            this.filterIdsTextBox.Name = "filterIdsTextBox";
            this.filterIdsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.filterIdsTextBox.Size = new System.Drawing.Size(188, 85);
            this.filterIdsTextBox.TabIndex = 2;
            // 
            // filterIdsStartsWithTextBox
            // 
            this.filterIdsStartsWithTextBox.Location = new System.Drawing.Point(6, 196);
            this.filterIdsStartsWithTextBox.Multiline = true;
            this.filterIdsStartsWithTextBox.Name = "filterIdsStartsWithTextBox";
            this.filterIdsStartsWithTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.filterIdsStartsWithTextBox.Size = new System.Drawing.Size(188, 79);
            this.filterIdsStartsWithTextBox.TabIndex = 3;
            // 
            // filterClassesTextBox
            // 
            this.filterClassesTextBox.Location = new System.Drawing.Point(6, 55);
            this.filterClassesTextBox.Multiline = true;
            this.filterClassesTextBox.Name = "filterClassesTextBox";
            this.filterClassesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.filterClassesTextBox.Size = new System.Drawing.Size(188, 220);
            this.filterClassesTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exact match by class, for example:\r\n<div class=\"ad\"...";
            // 
            // filterMessagesRadioButton
            // 
            this.filterMessagesRadioButton.AutoSize = true;
            this.filterMessagesRadioButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.filterMessagesRadioButton.Location = new System.Drawing.Point(12, 24);
            this.filterMessagesRadioButton.Name = "filterMessagesRadioButton";
            this.filterMessagesRadioButton.Size = new System.Drawing.Size(165, 30);
            this.filterMessagesRadioButton.TabIndex = 0;
            this.filterMessagesRadioButton.TabStop = true;
            this.filterMessagesRadioButton.Text = "Hide messages from members\r\nin the list";
            this.filterMessagesRadioButton.UseVisualStyleBackColor = true;
            // 
            // filterMessagesInverseModeRadioButton
            // 
            this.filterMessagesInverseModeRadioButton.AutoSize = true;
            this.filterMessagesInverseModeRadioButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.filterMessagesInverseModeRadioButton.Location = new System.Drawing.Point(12, 60);
            this.filterMessagesInverseModeRadioButton.Name = "filterMessagesInverseModeRadioButton";
            this.filterMessagesInverseModeRadioButton.Size = new System.Drawing.Size(178, 30);
            this.filterMessagesInverseModeRadioButton.TabIndex = 1;
            this.filterMessagesInverseModeRadioButton.TabStop = true;
            this.filterMessagesInverseModeRadioButton.Text = "Hide messages from all members\r\nexcept members from the list";
            this.filterMessagesInverseModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // filterMessagesTextBox
            // 
            this.filterMessagesTextBox.Location = new System.Drawing.Point(6, 96);
            this.filterMessagesTextBox.Multiline = true;
            this.filterMessagesTextBox.Name = "filterMessagesTextBox";
            this.filterMessagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.filterMessagesTextBox.Size = new System.Drawing.Size(188, 179);
            this.filterMessagesTextBox.TabIndex = 2;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 396);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filterIdsStartsWithTextBox;
        private System.Windows.Forms.TextBox filterIdsTextBox;
        private System.Windows.Forms.TextBox filterClassesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton filterMessagesInverseModeRadioButton;
        private System.Windows.Forms.RadioButton filterMessagesRadioButton;
        private System.Windows.Forms.TextBox filterMessagesTextBox;
    }
}