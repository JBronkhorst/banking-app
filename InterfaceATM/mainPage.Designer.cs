namespace InterfaceATM
{
    partial class mainPage
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.monitorPanel = new System.Windows.Forms.Panel();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.accountIDLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.viewTransactionsButton = new System.Windows.Forms.Button();
            this.changePinButton = new System.Windows.Forms.Button();
            this.viewBalanceButton = new System.Windows.Forms.Button();
            this.monitorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(183, 473);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(139, 57);
            this.closeButton.TabIndex = 25;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.Location = new System.Drawing.Point(523, 473);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(139, 57);
            this.acceptButton.TabIndex = 24;
            this.acceptButton.Text = "Withdraw Card";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // monitorPanel
            // 
            this.monitorPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.monitorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monitorPanel.Controls.Add(this.subtitleLabel);
            this.monitorPanel.Controls.Add(this.accountIDLabel);
            this.monitorPanel.Controls.Add(this.titleLabel);
            this.monitorPanel.Location = new System.Drawing.Point(183, 22);
            this.monitorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.monitorPanel.Name = "monitorPanel";
            this.monitorPanel.Size = new System.Drawing.Size(479, 443);
            this.monitorPanel.TabIndex = 13;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Location = new System.Drawing.Point(127, 246);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(210, 16);
            this.subtitleLabel.TabIndex = 4;
            this.subtitleLabel.Text = "Please select what you want to do.";
            // 
            // accountIDLabel
            // 
            this.accountIDLabel.AutoSize = true;
            this.accountIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountIDLabel.Location = new System.Drawing.Point(293, 218);
            this.accountIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountIDLabel.Name = "accountIDLabel";
            this.accountIDLabel.Size = new System.Drawing.Size(0, 20);
            this.accountIDLabel.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(100, 218);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(254, 20);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Welcome to ABC Banking Group";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.Location = new System.Drawing.Point(671, 332);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(4);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(139, 57);
            this.withdrawButton.TabIndex = 26;
            this.withdrawButton.Text = "Withdraw Money";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(671, 409);
            this.depositButton.Margin = new System.Windows.Forms.Padding(4);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(139, 57);
            this.depositButton.TabIndex = 27;
            this.depositButton.Text = "Deposit Money";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // viewTransactionsButton
            // 
            this.viewTransactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTransactionsButton.Location = new System.Drawing.Point(36, 332);
            this.viewTransactionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewTransactionsButton.Name = "viewTransactionsButton";
            this.viewTransactionsButton.Size = new System.Drawing.Size(139, 57);
            this.viewTransactionsButton.TabIndex = 28;
            this.viewTransactionsButton.Text = "Print Small Statement";
            this.viewTransactionsButton.UseVisualStyleBackColor = true;
            this.viewTransactionsButton.Click += new System.EventHandler(this.viewTransactionsButton_Click);
            // 
            // changePinButton
            // 
            this.changePinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePinButton.Location = new System.Drawing.Point(36, 409);
            this.changePinButton.Margin = new System.Windows.Forms.Padding(4);
            this.changePinButton.Name = "changePinButton";
            this.changePinButton.Size = new System.Drawing.Size(139, 57);
            this.changePinButton.TabIndex = 29;
            this.changePinButton.Text = "Change Pin";
            this.changePinButton.UseVisualStyleBackColor = true;
            this.changePinButton.Click += new System.EventHandler(this.changePinButton_Click);
            // 
            // viewBalanceButton
            // 
            this.viewBalanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBalanceButton.Location = new System.Drawing.Point(36, 255);
            this.viewBalanceButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewBalanceButton.Name = "viewBalanceButton";
            this.viewBalanceButton.Size = new System.Drawing.Size(139, 57);
            this.viewBalanceButton.TabIndex = 30;
            this.viewBalanceButton.Text = "View Balance";
            this.viewBalanceButton.UseVisualStyleBackColor = true;
            this.viewBalanceButton.Click += new System.EventHandler(this.viewBalanceButton_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 559);
            this.Controls.Add(this.viewBalanceButton);
            this.Controls.Add(this.changePinButton);
            this.Controls.Add(this.viewTransactionsButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.monitorPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainPage_FormClosed);
            this.monitorPanel.ResumeLayout(false);
            this.monitorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Panel monitorPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button viewTransactionsButton;
        private System.Windows.Forms.Button changePinButton;
        private System.Windows.Forms.Button viewBalanceButton;
        private System.Windows.Forms.Label accountIDLabel;
        private System.Windows.Forms.Label subtitleLabel;
    }
}