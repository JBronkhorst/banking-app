namespace InterfaceDesktop
{
    partial class externalTransaction
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.branchCodeLabel = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.branchCodeTextbox = new System.Windows.Forms.TextBox();
            this.performTransactionButton = new System.Windows.Forms.Button();
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(21, 44);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(310, 16);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Added to show functionality, this should not be here.";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(37, 95);
            this.accountNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(106, 16);
            this.accountNumberLabel.TabIndex = 2;
            this.accountNumberLabel.Text = "Account Number";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(37, 144);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(52, 16);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Amount";
            // 
            // branchCodeLabel
            // 
            this.branchCodeLabel.AutoSize = true;
            this.branchCodeLabel.Location = new System.Drawing.Point(37, 193);
            this.branchCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branchCodeLabel.Name = "branchCodeLabel";
            this.branchCodeLabel.Size = new System.Drawing.Size(85, 16);
            this.branchCodeLabel.TabIndex = 4;
            this.branchCodeLabel.Text = "Branch Code";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(161, 90);
            this.accountNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(179, 22);
            this.accountNumberTextBox.TabIndex = 5;
            // 
            // amountTextbox
            // 
            this.amountTextbox.Location = new System.Drawing.Point(161, 139);
            this.amountTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(179, 22);
            this.amountTextbox.TabIndex = 6;
            // 
            // branchCodeTextbox
            // 
            this.branchCodeTextbox.Location = new System.Drawing.Point(161, 190);
            this.branchCodeTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.branchCodeTextbox.Name = "branchCodeTextbox";
            this.branchCodeTextbox.Size = new System.Drawing.Size(179, 22);
            this.branchCodeTextbox.TabIndex = 7;
            // 
            // performTransactionButton
            // 
            this.performTransactionButton.Location = new System.Drawing.Point(41, 231);
            this.performTransactionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.performTransactionButton.Name = "performTransactionButton";
            this.performTransactionButton.Size = new System.Drawing.Size(300, 36);
            this.performTransactionButton.TabIndex = 8;
            this.performTransactionButton.Text = "Perform Transaction";
            this.performTransactionButton.UseVisualStyleBackColor = true;
            this.performTransactionButton.Click += new System.EventHandler(this.performTransactionButton_Click);
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLabel.Location = new System.Drawing.Point(91, 15);
            this.mainTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(183, 20);
            this.mainTitleLabel.TabIndex = 9;
            this.mainTitleLabel.Text = "External Transaction";
            // 
            // externalTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 288);
            this.Controls.Add(this.mainTitleLabel);
            this.Controls.Add(this.performTransactionButton);
            this.Controls.Add(this.branchCodeTextbox);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.branchCodeLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "externalTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "External Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label branchCodeLabel;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.TextBox branchCodeTextbox;
        private System.Windows.Forms.Button performTransactionButton;
        private System.Windows.Forms.Label mainTitleLabel;
    }
}