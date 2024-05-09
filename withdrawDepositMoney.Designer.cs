namespace InterfaceDesktop
{
    partial class withdrawDepositMoney
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
            this.withdrawLabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.depositTextbox = new System.Windows.Forms.TextBox();
            this.withdrawTextbox = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawAmountLabel = new System.Windows.Forms.Label();
            this.depositAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // withdrawLabel
            // 
            this.withdrawLabel.AutoSize = true;
            this.withdrawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawLabel.Location = new System.Drawing.Point(121, 62);
            this.withdrawLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.withdrawLabel.Name = "withdrawLabel";
            this.withdrawLabel.Size = new System.Drawing.Size(147, 20);
            this.withdrawLabel.TabIndex = 1;
            this.withdrawLabel.Text = "Withdraw Money";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.Location = new System.Drawing.Point(127, 192);
            this.depositLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(134, 20);
            this.depositLabel.TabIndex = 2;
            this.depositLabel.Text = "Deposit Money";
            // 
            // depositTextbox
            // 
            this.depositTextbox.Location = new System.Drawing.Point(136, 256);
            this.depositTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.depositTextbox.Name = "depositTextbox";
            this.depositTextbox.Size = new System.Drawing.Size(132, 22);
            this.depositTextbox.TabIndex = 3;
            // 
            // withdrawTextbox
            // 
            this.withdrawTextbox.Location = new System.Drawing.Point(136, 110);
            this.withdrawTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.withdrawTextbox.Name = "withdrawTextbox";
            this.withdrawTextbox.Size = new System.Drawing.Size(132, 22);
            this.withdrawTextbox.TabIndex = 4;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(277, 108);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(4);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(100, 28);
            this.withdrawButton.TabIndex = 5;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(277, 255);
            this.depositButton.Margin = new System.Windows.Forms.Padding(4);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(100, 28);
            this.depositButton.TabIndex = 6;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawAmountLabel
            // 
            this.withdrawAmountLabel.AutoSize = true;
            this.withdrawAmountLabel.Location = new System.Drawing.Point(31, 113);
            this.withdrawAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.withdrawAmountLabel.Name = "withdrawAmountLabel";
            this.withdrawAmountLabel.Size = new System.Drawing.Size(86, 16);
            this.withdrawAmountLabel.TabIndex = 7;
            this.withdrawAmountLabel.Text = "Enter Amount";
            // 
            // depositAmountLabel
            // 
            this.depositAmountLabel.AutoSize = true;
            this.depositAmountLabel.Location = new System.Drawing.Point(31, 260);
            this.depositAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depositAmountLabel.Name = "depositAmountLabel";
            this.depositAmountLabel.Size = new System.Drawing.Size(86, 16);
            this.depositAmountLabel.TabIndex = 8;
            this.depositAmountLabel.Text = "Enter Amount";
            // 
            // withdrawDepositMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 322);
            this.Controls.Add(this.depositAmountLabel);
            this.Controls.Add(this.withdrawAmountLabel);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.withdrawTextbox);
            this.Controls.Add(this.depositTextbox);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.withdrawLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "withdrawDepositMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw and Deposit Money";
            this.Load += new System.EventHandler(this.withdrawDepositMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label withdrawLabel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.TextBox depositTextbox;
        private System.Windows.Forms.TextBox withdrawTextbox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Label withdrawAmountLabel;
        private System.Windows.Forms.Label depositAmountLabel;
    }
}