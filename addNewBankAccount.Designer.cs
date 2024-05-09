namespace InterfaceDesktop
{
    partial class addNewBankAccount
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
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.currentRadioButton = new System.Windows.Forms.RadioButton();
            this.savingRadioButton = new System.Windows.Forms.RadioButton();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(81, 11);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(205, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Add New Bank Account";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Location = new System.Drawing.Point(131, 39);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(120, 16);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "Please fill all fields.";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(49, 84);
            this.accountTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(90, 16);
            this.accountTypeLabel.TabIndex = 2;
            this.accountTypeLabel.Text = "Account Type";
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Location = new System.Drawing.Point(49, 130);
            this.pinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(80, 16);
            this.pinLabel.TabIndex = 3;
            this.pinLabel.Text = "Account PIN";
            // 
            // pinTextBox
            // 
            this.pinTextBox.Location = new System.Drawing.Point(163, 127);
            this.pinTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pinTextBox.MaxLength = 4;
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.PasswordChar = '•';
            this.pinTextBox.Size = new System.Drawing.Size(165, 22);
            this.pinTextBox.TabIndex = 4;
            // 
            // currentRadioButton
            // 
            this.currentRadioButton.AutoSize = true;
            this.currentRadioButton.Location = new System.Drawing.Point(167, 81);
            this.currentRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentRadioButton.Name = "currentRadioButton";
            this.currentRadioButton.Size = new System.Drawing.Size(70, 20);
            this.currentRadioButton.TabIndex = 5;
            this.currentRadioButton.TabStop = true;
            this.currentRadioButton.Text = "Current";
            this.currentRadioButton.UseVisualStyleBackColor = true;
            // 
            // savingRadioButton
            // 
            this.savingRadioButton.AutoSize = true;
            this.savingRadioButton.Location = new System.Drawing.Point(259, 81);
            this.savingRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savingRadioButton.Name = "savingRadioButton";
            this.savingRadioButton.Size = new System.Drawing.Size(70, 20);
            this.savingRadioButton.TabIndex = 6;
            this.savingRadioButton.TabStop = true;
            this.savingRadioButton.Text = "Saving";
            this.savingRadioButton.UseVisualStyleBackColor = true;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(53, 166);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(276, 37);
            this.createAccountButton.TabIndex = 7;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // addNewBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 230);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.savingRadioButton);
            this.Controls.Add(this.currentRadioButton);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addNewBankAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Bank Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addNewBankAccount_FormClosed);
            this.Load += new System.EventHandler(this.addNewBankAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.RadioButton currentRadioButton;
        private System.Windows.Forms.RadioButton savingRadioButton;
        private System.Windows.Forms.Button createAccountButton;
    }
}