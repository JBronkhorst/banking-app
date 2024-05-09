namespace InterfaceDesktop
{
    partial class editClientBankSettings
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
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.overdraftLabel = new System.Windows.Forms.Label();
            this.overdraftTextbox = new System.Windows.Forms.TextBox();
            this.interestRateTextbox = new System.Windows.Forms.TextBox();
            this.accountIDLabel = new System.Windows.Forms.Label();
            this.accountIDtextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateSettingsButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.accountTypeTextbox = new System.Windows.Forms.Label();
            this.deleteBankAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(73, 138);
            this.interestRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(82, 16);
            this.interestRateLabel.TabIndex = 2;
            this.interestRateLabel.Text = "Interest Rate";
            // 
            // overdraftLabel
            // 
            this.overdraftLabel.AutoSize = true;
            this.overdraftLabel.Location = new System.Drawing.Point(73, 188);
            this.overdraftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.overdraftLabel.Name = "overdraftLabel";
            this.overdraftLabel.Size = new System.Drawing.Size(62, 16);
            this.overdraftLabel.TabIndex = 3;
            this.overdraftLabel.Text = "Overdraft";
            // 
            // overdraftTextbox
            // 
            this.overdraftTextbox.Location = new System.Drawing.Point(167, 185);
            this.overdraftTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.overdraftTextbox.Name = "overdraftTextbox";
            this.overdraftTextbox.Size = new System.Drawing.Size(132, 22);
            this.overdraftTextbox.TabIndex = 4;
            // 
            // interestRateTextbox
            // 
            this.interestRateTextbox.Location = new System.Drawing.Point(167, 134);
            this.interestRateTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.interestRateTextbox.Name = "interestRateTextbox";
            this.interestRateTextbox.Size = new System.Drawing.Size(132, 22);
            this.interestRateTextbox.TabIndex = 5;
            // 
            // accountIDLabel
            // 
            this.accountIDLabel.AutoSize = true;
            this.accountIDLabel.Location = new System.Drawing.Point(28, 46);
            this.accountIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountIDLabel.Name = "accountIDLabel";
            this.accountIDLabel.Size = new System.Drawing.Size(71, 16);
            this.accountIDLabel.TabIndex = 6;
            this.accountIDLabel.Text = "Account ID";
            // 
            // accountIDtextBox
            // 
            this.accountIDtextBox.Location = new System.Drawing.Point(116, 42);
            this.accountIDtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountIDtextBox.Name = "accountIDtextBox";
            this.accountIDtextBox.Size = new System.Drawing.Size(132, 22);
            this.accountIDtextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(255, 39);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateSettingsButton
            // 
            this.updateSettingsButton.Location = new System.Drawing.Point(75, 274);
            this.updateSettingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateSettingsButton.Name = "updateSettingsButton";
            this.updateSettingsButton.Size = new System.Drawing.Size(225, 36);
            this.updateSettingsButton.TabIndex = 9;
            this.updateSettingsButton.Text = "Update Settings";
            this.updateSettingsButton.UseVisualStyleBackColor = true;
            this.updateSettingsButton.Click += new System.EventHandler(this.updateSettingsButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(9, 11);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(319, 18);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Please enter Account ID and click Search";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.Location = new System.Drawing.Point(76, 97);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(197, 18);
            this.subtitleLabel.TabIndex = 11;
            this.subtitleLabel.Text = "Results are shown below";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(73, 236);
            this.accountTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(90, 16);
            this.accountTypeLabel.TabIndex = 12;
            this.accountTypeLabel.Text = "Account Type";
            // 
            // accountTypeTextbox
            // 
            this.accountTypeTextbox.AutoSize = true;
            this.accountTypeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeTextbox.Location = new System.Drawing.Point(181, 236);
            this.accountTypeTextbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountTypeTextbox.Name = "accountTypeTextbox";
            this.accountTypeTextbox.Size = new System.Drawing.Size(0, 17);
            this.accountTypeTextbox.TabIndex = 13;
            // 
            // deleteBankAccountButton
            // 
            this.deleteBankAccountButton.Location = new System.Drawing.Point(75, 326);
            this.deleteBankAccountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBankAccountButton.Name = "deleteBankAccountButton";
            this.deleteBankAccountButton.Size = new System.Drawing.Size(224, 36);
            this.deleteBankAccountButton.TabIndex = 14;
            this.deleteBankAccountButton.Text = "Delete Account";
            this.deleteBankAccountButton.UseVisualStyleBackColor = true;
            this.deleteBankAccountButton.Click += new System.EventHandler(this.deleteBankAccountButton_Click);
            // 
            // editClientBankSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 375);
            this.Controls.Add(this.deleteBankAccountButton);
            this.Controls.Add(this.accountTypeTextbox);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.updateSettingsButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.accountIDtextBox);
            this.Controls.Add(this.accountIDLabel);
            this.Controls.Add(this.interestRateTextbox);
            this.Controls.Add(this.overdraftTextbox);
            this.Controls.Add(this.overdraftLabel);
            this.Controls.Add(this.interestRateLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "editClientBankSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Bank Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label overdraftLabel;
        private System.Windows.Forms.TextBox overdraftTextbox;
        private System.Windows.Forms.TextBox interestRateTextbox;
        private System.Windows.Forms.Label accountIDLabel;
        private System.Windows.Forms.TextBox accountIDtextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateSettingsButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label accountTypeTextbox;
        private System.Windows.Forms.Button deleteBankAccountButton;
    }
}
