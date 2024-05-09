namespace InterfaceDesktop
{
    partial class BankAccountMain
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
            this.accountIDText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawAndDepositMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.openDateLabel = new System.Windows.Forms.Label();
            this.InterestRateLabel = new System.Windows.Forms.Label();
            this.overdraftLimitLabel = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.accountTypeText = new System.Windows.Forms.Label();
            this.openDateText = new System.Windows.Forms.Label();
            this.interestRateText = new System.Windows.Forms.Label();
            this.overdraftLimitText = new System.Windows.Forms.Label();
            this.viewBalanceButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountIDText
            // 
            this.accountIDText.AutoSize = true;
            this.accountIDText.Location = new System.Drawing.Point(211, 73);
            this.accountIDText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountIDText.Name = "accountIDText";
            this.accountIDText.Size = new System.Drawing.Size(0, 16);
            this.accountIDText.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTransactionsToolStripMenuItem,
            this.withdrawAndDepositMoneyToolStripMenuItem,
            this.transferMoneyToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // viewTransactionsToolStripMenuItem
            // 
            this.viewTransactionsToolStripMenuItem.Name = "viewTransactionsToolStripMenuItem";
            this.viewTransactionsToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.viewTransactionsToolStripMenuItem.Text = "View Transactions";
            this.viewTransactionsToolStripMenuItem.Click += new System.EventHandler(this.viewTransactionsToolStripMenuItem_Click);
            // 
            // withdrawAndDepositMoneyToolStripMenuItem
            // 
            this.withdrawAndDepositMoneyToolStripMenuItem.Name = "withdrawAndDepositMoneyToolStripMenuItem";
            this.withdrawAndDepositMoneyToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.withdrawAndDepositMoneyToolStripMenuItem.Text = "Withdraw and Deposit Money";
            this.withdrawAndDepositMoneyToolStripMenuItem.Click += new System.EventHandler(this.withdrawAndDepositMoneyToolStripMenuItem_Click);
            // 
            // transferMoneyToolStripMenuItem
            // 
            this.transferMoneyToolStripMenuItem.Name = "transferMoneyToolStripMenuItem";
            this.transferMoneyToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.transferMoneyToolStripMenuItem.Text = "Transfer Money";
            this.transferMoneyToolStripMenuItem.Click += new System.EventHandler(this.transferMoneyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLabel.Location = new System.Drawing.Point(69, 73);
            this.accountNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(117, 17);
            this.accountNumberLabel.TabIndex = 2;
            this.accountNumberLabel.Text = "Account Number:";
            // 
            // openDateLabel
            // 
            this.openDateLabel.AutoSize = true;
            this.openDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openDateLabel.Location = new System.Drawing.Point(69, 151);
            this.openDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.openDateLabel.Name = "openDateLabel";
            this.openDateLabel.Size = new System.Drawing.Size(81, 17);
            this.openDateLabel.TabIndex = 3;
            this.openDateLabel.Text = "Open Date:";
            // 
            // InterestRateLabel
            // 
            this.InterestRateLabel.AutoSize = true;
            this.InterestRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestRateLabel.Location = new System.Drawing.Point(69, 191);
            this.InterestRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InterestRateLabel.Name = "InterestRateLabel";
            this.InterestRateLabel.Size = new System.Drawing.Size(93, 17);
            this.InterestRateLabel.TabIndex = 4;
            this.InterestRateLabel.Text = "Interest Rate:";
            // 
            // overdraftLimitLabel
            // 
            this.overdraftLimitLabel.AutoSize = true;
            this.overdraftLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdraftLimitLabel.Location = new System.Drawing.Point(69, 230);
            this.overdraftLimitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.overdraftLimitLabel.Name = "overdraftLimitLabel";
            this.overdraftLimitLabel.Size = new System.Drawing.Size(105, 17);
            this.overdraftLimitLabel.TabIndex = 5;
            this.overdraftLimitLabel.Text = "Overdraft Limit:";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeLabel.Location = new System.Drawing.Point(69, 112);
            this.accountTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(99, 17);
            this.accountTypeLabel.TabIndex = 6;
            this.accountTypeLabel.Text = "Account Type:";
            // 
            // accountTypeText
            // 
            this.accountTypeText.AutoSize = true;
            this.accountTypeText.Location = new System.Drawing.Point(211, 112);
            this.accountTypeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountTypeText.Name = "accountTypeText";
            this.accountTypeText.Size = new System.Drawing.Size(0, 16);
            this.accountTypeText.TabIndex = 7;
            // 
            // openDateText
            // 
            this.openDateText.AutoSize = true;
            this.openDateText.Location = new System.Drawing.Point(211, 151);
            this.openDateText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.openDateText.Name = "openDateText";
            this.openDateText.Size = new System.Drawing.Size(0, 16);
            this.openDateText.TabIndex = 8;
            // 
            // interestRateText
            // 
            this.interestRateText.AutoSize = true;
            this.interestRateText.Location = new System.Drawing.Point(211, 191);
            this.interestRateText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.interestRateText.Name = "interestRateText";
            this.interestRateText.Size = new System.Drawing.Size(0, 16);
            this.interestRateText.TabIndex = 9;
            // 
            // overdraftLimitText
            // 
            this.overdraftLimitText.AutoSize = true;
            this.overdraftLimitText.Location = new System.Drawing.Point(211, 230);
            this.overdraftLimitText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.overdraftLimitText.Name = "overdraftLimitText";
            this.overdraftLimitText.Size = new System.Drawing.Size(0, 16);
            this.overdraftLimitText.TabIndex = 10;
            // 
            // viewBalanceButton
            // 
            this.viewBalanceButton.Location = new System.Drawing.Point(76, 263);
            this.viewBalanceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewBalanceButton.Name = "viewBalanceButton";
            this.viewBalanceButton.Size = new System.Drawing.Size(268, 41);
            this.viewBalanceButton.TabIndex = 11;
            this.viewBalanceButton.Text = "View Balance";
            this.viewBalanceButton.UseVisualStyleBackColor = true;
            this.viewBalanceButton.Click += new System.EventHandler(this.viewBalanceButton_Click);
            // 
            // BankAccountMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 359);
            this.Controls.Add(this.viewBalanceButton);
            this.Controls.Add(this.overdraftLimitText);
            this.Controls.Add(this.interestRateText);
            this.Controls.Add(this.openDateText);
            this.Controls.Add(this.accountTypeText);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.overdraftLimitLabel);
            this.Controls.Add(this.InterestRateLabel);
            this.Controls.Add(this.openDateLabel);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.accountIDText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BankAccountMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Account";
            this.Load += new System.EventHandler(this.BankAccountMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountIDText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label openDateLabel;
        private System.Windows.Forms.Label InterestRateLabel;
        private System.Windows.Forms.Label overdraftLimitLabel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label accountTypeText;
        private System.Windows.Forms.Label openDateText;
        private System.Windows.Forms.Label interestRateText;
        private System.Windows.Forms.Label overdraftLimitText;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawAndDepositMoneyToolStripMenuItem;
        private System.Windows.Forms.Button viewBalanceButton;
        private System.Windows.Forms.ToolStripMenuItem transferMoneyToolStripMenuItem;
    }
}
