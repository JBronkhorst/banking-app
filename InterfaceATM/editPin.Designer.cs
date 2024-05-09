namespace InterfaceATM
{
    partial class editPin
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
            this.newPinTextbox = new System.Windows.Forms.TextBox();
            this.editPinButton = new System.Windows.Forms.Button();
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
            this.monitorPanel.Controls.Add(this.newPinTextbox);
            this.monitorPanel.Controls.Add(this.editPinButton);
            this.monitorPanel.Controls.Add(this.subtitleLabel);
            this.monitorPanel.Location = new System.Drawing.Point(183, 22);
            this.monitorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.monitorPanel.Name = "monitorPanel";
            this.monitorPanel.Size = new System.Drawing.Size(479, 443);
            this.monitorPanel.TabIndex = 26;
            // 
            // newPinTextbox
            // 
            this.newPinTextbox.Location = new System.Drawing.Point(179, 193);
            this.newPinTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.newPinTextbox.MaxLength = 4;
            this.newPinTextbox.Name = "newPinTextbox";
            this.newPinTextbox.PasswordChar = '•';
            this.newPinTextbox.Size = new System.Drawing.Size(116, 22);
            this.newPinTextbox.TabIndex = 6;
            // 
            // editPinButton
            // 
            this.editPinButton.Location = new System.Drawing.Point(179, 226);
            this.editPinButton.Margin = new System.Windows.Forms.Padding(4);
            this.editPinButton.Name = "editPinButton";
            this.editPinButton.Size = new System.Drawing.Size(117, 36);
            this.editPinButton.TabIndex = 5;
            this.editPinButton.Text = "Change PIN";
            this.editPinButton.UseVisualStyleBackColor = true;
            this.editPinButton.Click += new System.EventHandler(this.editPinButton_Click);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.Location = new System.Drawing.Point(175, 165);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(116, 20);
            this.subtitleLabel.TabIndex = 4;
            this.subtitleLabel.Text = "Enter new PIN";
            // 
            // editPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 549);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.monitorPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit Account PIN";
            this.monitorPanel.ResumeLayout(false);
            this.monitorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Panel monitorPanel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.TextBox newPinTextbox;
        private System.Windows.Forms.Button editPinButton;
    }
}