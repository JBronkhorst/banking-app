namespace InterfaceDesktop
{
    partial class StaffClientMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAccountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externalTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.bankAccountToolStripMenuItem,
            this.exitApplicationToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(507, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDetailsToolStripMenuItem,
            this.delteAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.accountToolStripMenuItem.Text = "Client account";
            // 
            // editDetailsToolStripMenuItem
            // 
            this.editDetailsToolStripMenuItem.Name = "editDetailsToolStripMenuItem";
            this.editDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.editDetailsToolStripMenuItem.Text = "Edit Details";
            this.editDetailsToolStripMenuItem.Click += new System.EventHandler(this.editDetailsToolStripMenuItem_Click);
            // 
            // delteAccountToolStripMenuItem
            // 
            this.delteAccountToolStripMenuItem.Name = "delteAccountToolStripMenuItem";
            this.delteAccountToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.delteAccountToolStripMenuItem.Text = "Delete Account";
            this.delteAccountToolStripMenuItem.Click += new System.EventHandler(this.delteAccountToolStripMenuItem_Click);
            // 
            // bankAccountToolStripMenuItem
            // 
            this.bankAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewClientsToolStripMenuItem,
            this.viewAccountsToolStripMenuItem,
            this.changeAccountSettingsToolStripMenuItem,
            this.externalTransactionToolStripMenuItem});
            this.bankAccountToolStripMenuItem.Name = "bankAccountToolStripMenuItem";
            this.bankAccountToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.bankAccountToolStripMenuItem.Text = "Client management";
            // 
            // viewClientsToolStripMenuItem
            // 
            this.viewClientsToolStripMenuItem.Name = "viewClientsToolStripMenuItem";
            this.viewClientsToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.viewClientsToolStripMenuItem.Text = "View clients";
            this.viewClientsToolStripMenuItem.Click += new System.EventHandler(this.viewClientsToolStripMenuItem_Click);
            // 
            // viewAccountsToolStripMenuItem
            // 
            this.viewAccountsToolStripMenuItem.Name = "viewAccountsToolStripMenuItem";
            this.viewAccountsToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.viewAccountsToolStripMenuItem.Text = "View Accounts";
            this.viewAccountsToolStripMenuItem.Click += new System.EventHandler(this.viewAccountsToolStripMenuItem_Click);
            // 
            // changeAccountSettingsToolStripMenuItem
            // 
            this.changeAccountSettingsToolStripMenuItem.Name = "changeAccountSettingsToolStripMenuItem";
            this.changeAccountSettingsToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.changeAccountSettingsToolStripMenuItem.Text = "Change Account Settings";
            this.changeAccountSettingsToolStripMenuItem.Click += new System.EventHandler(this.changeAccountSettingsToolStripMenuItem_Click);
            // 
            // externalTransactionToolStripMenuItem
            // 
            this.externalTransactionToolStripMenuItem.Name = "externalTransactionToolStripMenuItem";
            this.externalTransactionToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.externalTransactionToolStripMenuItem.Text = "External Transaction";
            this.externalTransactionToolStripMenuItem.Click += new System.EventHandler(this.externalTransactionToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem1
            // 
            this.exitApplicationToolStripMenuItem1.Name = "exitApplicationToolStripMenuItem1";
            this.exitApplicationToolStripMenuItem1.Size = new System.Drawing.Size(128, 24);
            this.exitApplicationToolStripMenuItem1.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem1.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(78, 117);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(326, 25);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Welcome to ABC Banking Group";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.Location = new System.Drawing.Point(80, 151);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(324, 20);
            this.subtitleLabel.TabIndex = 2;
            this.subtitleLabel.Text = "Please use the menu above for navigation.";
            // 
            // StaffClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(507, 322);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffClientMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Bank";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffClientMain_FormClosed);
            this.Load += new System.EventHandler(this.StaffClientMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankAccountToolStripMenuItem;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAccountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externalTransactionToolStripMenuItem;
    }
}
