namespace InterfaceDesktop
{
    partial class CorporateClientMain
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
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountIDComboBox = new System.Windows.Forms.ComboBox();
            this.createNewAccountButton = new System.Windows.Forms.Button();
            this.viewBankAccountID = new System.Windows.Forms.Button();
            this.accountIDLabel = new System.Windows.Forms.Label();
            this.bankAccountTitleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.exitApplicationToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(429, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDetailsToolStripMenuItem,
            this.delteAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.accountToolStripMenuItem.Text = "Customer Account";
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
            // exitApplicationToolStripMenuItem1
            // 
            this.exitApplicationToolStripMenuItem1.Name = "exitApplicationToolStripMenuItem1";
            this.exitApplicationToolStripMenuItem1.Size = new System.Drawing.Size(128, 24);
            this.exitApplicationToolStripMenuItem1.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem1.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem1_Click);
            // 
            // accountIDComboBox
            // 
            this.accountIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountIDComboBox.FormattingEnabled = true;
            this.accountIDComboBox.Location = new System.Drawing.Point(139, 177);
            this.accountIDComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.accountIDComboBox.Name = "accountIDComboBox";
            this.accountIDComboBox.Size = new System.Drawing.Size(160, 24);
            this.accountIDComboBox.TabIndex = 17;
            // 
            // createNewAccountButton
            // 
            this.createNewAccountButton.Location = new System.Drawing.Point(23, 220);
            this.createNewAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.createNewAccountButton.Name = "createNewAccountButton";
            this.createNewAccountButton.Size = new System.Drawing.Size(383, 38);
            this.createNewAccountButton.TabIndex = 16;
            this.createNewAccountButton.Text = "Create new Bank Account";
            this.createNewAccountButton.UseVisualStyleBackColor = true;
            this.createNewAccountButton.Click += new System.EventHandler(this.createNewAccountButton_Click_1);
            // 
            // viewBankAccountID
            // 
            this.viewBankAccountID.Location = new System.Drawing.Point(305, 176);
            this.viewBankAccountID.Margin = new System.Windows.Forms.Padding(4);
            this.viewBankAccountID.Name = "viewBankAccountID";
            this.viewBankAccountID.Size = new System.Drawing.Size(100, 28);
            this.viewBankAccountID.TabIndex = 15;
            this.viewBankAccountID.Text = "View";
            this.viewBankAccountID.UseVisualStyleBackColor = true;
            this.viewBankAccountID.Click += new System.EventHandler(this.viewBankAccountID_Click_1);
            // 
            // accountIDLabel
            // 
            this.accountIDLabel.AutoSize = true;
            this.accountIDLabel.Location = new System.Drawing.Point(19, 182);
            this.accountIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountIDLabel.Name = "accountIDLabel";
            this.accountIDLabel.Size = new System.Drawing.Size(106, 16);
            this.accountIDLabel.TabIndex = 14;
            this.accountIDLabel.Text = "Account Number";
            // 
            // bankAccountTitleLabel
            // 
            this.bankAccountTitleLabel.AutoSize = true;
            this.bankAccountTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankAccountTitleLabel.Location = new System.Drawing.Point(37, 101);
            this.bankAccountTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bankAccountTitleLabel.Name = "bankAccountTitleLabel";
            this.bankAccountTitleLabel.Size = new System.Drawing.Size(329, 24);
            this.bankAccountTitleLabel.TabIndex = 13;
            this.bankAccountTitleLabel.Text = "Manage your Bank Accounts Here";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.Location = new System.Drawing.Point(48, 134);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(309, 20);
            this.subtitleLabel.TabIndex = 12;
            this.subtitleLabel.Text = "Please select an account and click View";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-5, 61);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(434, 31);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Welcome to ABC Banking Group";
            // 
            // CorporateClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(429, 322);
            this.Controls.Add(this.accountIDComboBox);
            this.Controls.Add(this.createNewAccountButton);
            this.Controls.Add(this.viewBankAccountID);
            this.Controls.Add(this.accountIDLabel);
            this.Controls.Add(this.bankAccountTitleLabel);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CorporateClientMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corporate Bank";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CorporateClientMain_FormClosed);
            this.Load += new System.EventHandler(this.CorporateClientMain_Load);
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
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.ComboBox accountIDComboBox;
        private System.Windows.Forms.Button createNewAccountButton;
        private System.Windows.Forms.Button viewBankAccountID;
        private System.Windows.Forms.Label accountIDLabel;
        private System.Windows.Forms.Label bankAccountTitleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}