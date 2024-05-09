namespace InterfaceATM
{
    partial class withdrawMoney
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
            this.amountTitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.subtitleLabel = new System.Windows.Forms.Label();
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
            this.closeButton.TabIndex = 51;
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
            this.acceptButton.TabIndex = 50;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // monitorPanel
            // 
            this.monitorPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.monitorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monitorPanel.Controls.Add(this.amountTitleLabel);
            this.monitorPanel.Controls.Add(this.titleLabel);
            this.monitorPanel.Controls.Add(this.amountTextbox);
            this.monitorPanel.Controls.Add(this.subtitleLabel);
            this.monitorPanel.Location = new System.Drawing.Point(183, 22);
            this.monitorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.monitorPanel.Name = "monitorPanel";
            this.monitorPanel.Size = new System.Drawing.Size(479, 443);
            this.monitorPanel.TabIndex = 39;
            // 
            // amountTitleLabel
            // 
            this.amountTitleLabel.AutoSize = true;
            this.amountTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTitleLabel.Location = new System.Drawing.Point(201, 348);
            this.amountTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountTitleLabel.Name = "amountTitleLabel";
            this.amountTitleLabel.Size = new System.Drawing.Size(0, 29);
            this.amountTitleLabel.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(165, 316);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(145, 20);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "You can withdraw:";
            // 
            // amountTextbox
            // 
            this.amountTextbox.Location = new System.Drawing.Point(179, 171);
            this.amountTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(116, 22);
            this.amountTextbox.TabIndex = 6;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.Location = new System.Drawing.Point(180, 143);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(111, 20);
            this.subtitleLabel.TabIndex = 4;
            this.subtitleLabel.Text = "Enter Amount";
            // 
            // withdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 566);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.monitorPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "withdrawMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw Money";
            this.monitorPanel.ResumeLayout(false);
            this.monitorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Panel monitorPanel;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label amountTitleLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}