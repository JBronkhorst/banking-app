namespace InterfaceDesktop
{
    partial class viewAccounts
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
            this.accountsGridView = new System.Windows.Forms.DataGridView();
            this.accountTotalLabel = new System.Windows.Forms.Label();
            this.accountTotalTextbox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountsGridView
            // 
            this.accountsGridView.AllowUserToAddRows = false;
            this.accountsGridView.AllowUserToDeleteRows = false;
            this.accountsGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.accountsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsGridView.Location = new System.Drawing.Point(7, 36);
            this.accountsGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountsGridView.Name = "accountsGridView";
            this.accountsGridView.ReadOnly = true;
            this.accountsGridView.RowHeadersWidth = 51;
            this.accountsGridView.Size = new System.Drawing.Size(993, 396);
            this.accountsGridView.TabIndex = 0;
            // 
            // accountTotalLabel
            // 
            this.accountTotalLabel.AutoSize = true;
            this.accountTotalLabel.Location = new System.Drawing.Point(12, 11);
            this.accountTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountTotalLabel.Name = "accountTotalLabel";
            this.accountTotalLabel.Size = new System.Drawing.Size(161, 16);
            this.accountTotalLabel.TabIndex = 1;
            this.accountTotalLabel.Text = "Total Amount of Accounts:";
            // 
            // accountTotalTextbox
            // 
            this.accountTotalTextbox.AutoSize = true;
            this.accountTotalTextbox.Location = new System.Drawing.Point(196, 11);
            this.accountTotalTextbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountTotalTextbox.Name = "accountTotalTextbox";
            this.accountTotalTextbox.Size = new System.Drawing.Size(0, 16);
            this.accountTotalTextbox.TabIndex = 2;
            // 
            // viewAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 437);
            this.Controls.Add(this.accountTotalTextbox);
            this.Controls.Add(this.accountTotalLabel);
            this.Controls.Add(this.accountsGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "viewAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Accounts";
            this.Load += new System.EventHandler(this.viewAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView accountsGridView;
        private System.Windows.Forms.Label accountTotalLabel;
        private System.Windows.Forms.Label accountTotalTextbox;
    }
}
