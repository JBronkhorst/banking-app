namespace InterfaceATM
{
    partial class viewBalance
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
            this.balanceTextbox = new System.Windows.Forms.Label();
            this.balanceTitleLabel = new System.Windows.Forms.Label();
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
            this.closeButton.TabIndex = 38;
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
            this.acceptButton.TabIndex = 37;
            this.acceptButton.Text = "Back";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // monitorPanel
            // 
            this.monitorPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.monitorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monitorPanel.Controls.Add(this.balanceTextbox);
            this.monitorPanel.Controls.Add(this.balanceTitleLabel);
            this.monitorPanel.Location = new System.Drawing.Point(183, 22);
            this.monitorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.monitorPanel.Name = "monitorPanel";
            this.monitorPanel.Size = new System.Drawing.Size(479, 443);
            this.monitorPanel.TabIndex = 26;
            // 
            // balanceTextbox
            // 
            this.balanceTextbox.AutoSize = true;
            this.balanceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTextbox.Location = new System.Drawing.Point(189, 203);
            this.balanceTextbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceTextbox.Name = "balanceTextbox";
            this.balanceTextbox.Size = new System.Drawing.Size(0, 31);
            this.balanceTextbox.TabIndex = 5;
            // 
            // balanceTitleLabel
            // 
            this.balanceTitleLabel.AutoSize = true;
            this.balanceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTitleLabel.Location = new System.Drawing.Point(121, 162);
            this.balanceTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceTitleLabel.Name = "balanceTitleLabel";
            this.balanceTitleLabel.Size = new System.Drawing.Size(221, 24);
            this.balanceTitleLabel.TabIndex = 4;
            this.balanceTitleLabel.Text = "Your Account Balance is:";
            // 
            // viewBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 552);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.monitorPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "viewBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM Account Balance";
            this.monitorPanel.ResumeLayout(false);
            this.monitorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Panel monitorPanel;
        private System.Windows.Forms.Label balanceTextbox;
        private System.Windows.Forms.Label balanceTitleLabel;
    }
}