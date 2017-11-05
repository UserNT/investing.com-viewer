namespace Viewer
{
    partial class MainForm
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
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consoleTextBox.Location = new System.Drawing.Point(0, 459);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTextBox.Size = new System.Drawing.Size(1008, 102);
            this.consoleTextBox.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1008, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem,
            this.goForwardToolStripMenuItem,
            this.toolStripMenuItem2,
            this.refreshToolStripMenuItem});
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.navigationToolStripMenuItem.Text = "Navigation";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.goBackToolStripMenuItem.Text = "Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // goForwardToolStripMenuItem
            // 
            this.goForwardToolStripMenuItem.Name = "goForwardToolStripMenuItem";
            this.goForwardToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.goForwardToolStripMenuItem.Text = "Forward";
            this.goForwardToolStripMenuItem.Click += new System.EventHandler(this.goForwardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterContentToolStripMenuItem,
            this.filterMessagesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // filterContentToolStripMenuItem
            // 
            this.filterContentToolStripMenuItem.Checked = true;
            this.filterContentToolStripMenuItem.CheckOnClick = true;
            this.filterContentToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.filterContentToolStripMenuItem.Name = "filterContentToolStripMenuItem";
            this.filterContentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.filterContentToolStripMenuItem.Text = "Filter Content";
            this.filterContentToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.filterContentToolStripMenuItem_CheckStateChanged);
            // 
            // filterMessagesToolStripMenuItem
            // 
            this.filterMessagesToolStripMenuItem.Checked = true;
            this.filterMessagesToolStripMenuItem.CheckOnClick = true;
            this.filterMessagesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.filterMessagesToolStripMenuItem.Name = "filterMessagesToolStripMenuItem";
            this.filterMessagesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.filterMessagesToolStripMenuItem.Text = "Filter Messages";
            this.filterMessagesToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.filterMessagesToolStripMenuItem_CheckStateChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripMenuItem,
            this.showLogToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.Checked = true;
            this.addressToolStripMenuItem.CheckOnClick = true;
            this.addressToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.addressToolStripMenuItem.Text = "Address";
            this.addressToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.addressToolStripMenuItem_CheckStateChanged);
            // 
            // showLogToolStripMenuItem
            // 
            this.showLogToolStripMenuItem.Checked = true;
            this.showLogToolStripMenuItem.CheckOnClick = true;
            this.showLogToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.showLogToolStripMenuItem.Name = "showLogToolStripMenuItem";
            this.showLogToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.showLogToolStripMenuItem.Text = "Logs";
            this.showLogToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.showLogToolStripMenuItem_CheckStateChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investing.com Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
    }
}

