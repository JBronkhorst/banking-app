namespace InterfaceATM
{
    partial class loginPage
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
            this.monitorPanel = new System.Windows.Forms.Panel();
            this.pinLabel = new System.Windows.Forms.Label();
            this.accountIDTextbox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pinTextbox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.monitorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monitorPanel
            // 
            this.monitorPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.monitorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monitorPanel.Controls.Add(this.pinLabel);
            this.monitorPanel.Controls.Add(this.accountIDTextbox);
            this.monitorPanel.Controls.Add(this.numberLabel);
            this.monitorPanel.Controls.Add(this.titleLabel);
            this.monitorPanel.Controls.Add(this.pinTextbox);
            this.monitorPanel.Location = new System.Drawing.Point(176, 21);
            this.monitorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.monitorPanel.Name = "monitorPanel";
            this.monitorPanel.Size = new System.Drawing.Size(479, 443);
            this.monitorPanel.TabIndex = 0;
            this.monitorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.monitorPanel_Paint);
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Location = new System.Drawing.Point(120, 222);
            this.pinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(29, 16);
            this.pinLabel.TabIndex = 14;
            this.pinLabel.Text = "PIN";
            // 
            // accountIDTextbox
            // 
            this.accountIDTextbox.Location = new System.Drawing.Point(172, 176);
            this.accountIDTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.accountIDTextbox.Name = "accountIDTextbox";
            this.accountIDTextbox.Size = new System.Drawing.Size(231, 22);
            this.accountIDTextbox.TabIndex = 3;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(37, 181);
            this.numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(106, 16);
            this.numberLabel.TabIndex = 13;
            this.numberLabel.Text = "Account Number";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(112, 28);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(249, 20);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Please enter your Bank Account";
            // 
            // pinTextbox
            // 
            this.pinTextbox.Location = new System.Drawing.Point(172, 217);
            this.pinTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.pinTextbox.MaxLength = 4;
            this.pinTextbox.Name = "pinTextbox";
            this.pinTextbox.PasswordChar = '•';
            this.pinTextbox.Size = new System.Drawing.Size(231, 22);
            this.pinTextbox.TabIndex = 1;
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.Location = new System.Drawing.Point(516, 472);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(139, 57);
            this.acceptButton.TabIndex = 11;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(176, 472);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(139, 57);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 551);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.monitorPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM Login";
            this.monitorPanel.ResumeLayout(false);
            this.monitorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel monitorPanel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox pinTextbox;
        private System.Windows.Forms.TextBox accountIDTextbox;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.Label numberLabel;
    }
}