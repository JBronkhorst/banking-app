namespace InterfaceDesktop
{
    partial class transferMoney
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
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.accountNumberTextbox = new System.Windows.Forms.TextBox();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.transferButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(47, 64);
            this.accountNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(126, 16);
            this.accountNumberLabel.TabIndex = 0;
            this.accountNumberLabel.Text = "To Account Number";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(49, 116);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(52, 16);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Amount";
            // 
            // accountNumberTextbox
            // 
            this.accountNumberTextbox.Location = new System.Drawing.Point(197, 60);
            this.accountNumberTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountNumberTextbox.Name = "accountNumberTextbox";
            this.accountNumberTextbox.Size = new System.Drawing.Size(132, 22);
            this.accountNumberTextbox.TabIndex = 2;
            // 
            // amountTextbox
            // 
            this.amountTextbox.Location = new System.Drawing.Point(197, 112);
            this.amountTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(132, 22);
            this.amountTextbox.TabIndex = 3;
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(51, 156);
            this.transferButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(280, 37);
            this.transferButton.TabIndex = 4;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(117, 11);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(140, 20);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Transfer Money";
            // 
            // transferMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 217);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.accountNumberTextbox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.accountNumberLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "transferMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Money";
            this.Load += new System.EventHandler(this.transferMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox accountNumberTextbox;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Label titleLabel;
    }
}