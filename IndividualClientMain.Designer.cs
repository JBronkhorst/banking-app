namespace InterfaceDesktop
{
    partial class IndividualClientMain
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.bankAccountTitleLabel = new System.Windows.Forms.Label();
            this.accountIDLabel = new System.Windows.Forms.Label();
            this.viewBankAccountID = new System.Windows.Forms.Button();
            this.createNewAccountButton = new System.Windows.Forms.Button();
            this.accountIDComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(431, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDetailsToolStripMenuItem,
            this.delteAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.accountToolStripMenuItem.Text = "Client Account";
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.exitToolStripMenuItem.Text = "Exit Application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.Location = new System.Drawing.Point(53, 137);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(309, 20);
            this.subtitleLabel.TabIndex = 4;
            this.subtitleLabel.Text = "Please select an account and click View";
            // 
            // bankAccountTitleLabel
            // 
            this.bankAccountTitleLabel.AutoSize = true;
            this.bankAccountTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankAccountTitleLabel.Location = new System.Drawing.Point(43, 103);
            this.bankAccountTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bankAccountTitleLabel.Name = "bankAccountTitleLabel";
            this.bankAccountTitleLabel.Size = new System.Drawing.Size(329, 24);
            this.bankAccountTitleLabel.TabIndex = 6;
            this.bankAccountTitleLabel.Text = "Manage your Bank Accounts Here";
            // 
            // accountIDLabel
            // 
            this.accountIDLabel.AutoSize = true;
            this.accountIDLabel.Location = new System.Drawing.Point(23, 185);
            this.accountIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountIDLabel.Name = "accountIDLabel";
            this.accountIDLabel.Size = new System.Drawing.Size(106, 16);
            this.accountIDLabel.TabIndex = 7;
            this.accountIDLabel.Text = "Account Number";
            // 
            // viewBankAccountID
            // 
            this.viewBankAccountID.Location = new System.Drawing.Point(311, 178);
            this.viewBankAccountID.Margin = new System.Windows.Forms.Padding(4);
            this.viewBankAccountID.Name = "viewBankAccountID";
            this.viewBankAccountID.Size = new System.Drawing.Size(100, 28);
            this.viewBankAccountID.TabIndex = 8;
            this.viewBankAccountID.Text = "View";
            this.viewBankAccountID.UseVisualStyleBackColor = true;
            this.viewBankAccountID.Click += new System.EventHandler(this.viewBankAccountID_Click);
            // 
            // createNewAccountButton
            // 
            this.createNewAccountButton.Location = new System.Drawing.Point(27, 223);
            this.createNewAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.createNewAccountButton.Name = "createNewAccountButton";
            this.createNewAccountButton.Size = new System.Drawing.Size(384, 38);
            this.createNewAccountButton.TabIndex = 9;
            this.createNewAccountButton.Text = "Create new Bank Account";
            this.createNewAccountButton.UseVisualStyleBackColor = true;
            this.createNewAccountButton.Click += new System.EventHandler(this.createNewAccountButton_Click);
            // 
            // accountIDComboBox
            // 
            this.accountIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountIDComboBox.FormattingEnabled = true;
            this.accountIDComboBox.Location = new System.Drawing.Point(144, 180);
            this.accountIDComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.accountIDComboBox.Name = "accountIDComboBox";
            this.accountIDComboBox.Size = new System.Drawing.Size(160, 24);
            this.accountIDComboBox.TabIndex = 10;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-3, 62);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(434, 31);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Welcome to ABC Banking Group";
            // 
            // IndividualClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 322);
            this.Controls.Add(this.accountIDComboBox);
            this.Controls.Add(this.createNewAccountButton);
            this.Controls.Add(this.viewBankAccountID);
            this.Controls.Add(this.accountIDLabel);
            this.Controls.Add(this.bankAccountTitleLabel);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IndividualClientMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Individual Bank";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IndividualClientMain_FormClosed);
            this.Load += new System.EventHandler(this.IndividualClientMain_Load);
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
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label bankAccountTitleLabel;
        private System.Windows.Forms.Label accountIDLabel;
        private System.Windows.Forms.Button viewBankAccountID;
        private System.Windows.Forms.Button createNewAccountButton;
        private System.Windows.Forms.ComboBox accountIDComboBox;
        private System.Windows.Forms.Label titleLabel;
    }
}