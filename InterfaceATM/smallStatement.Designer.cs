namespace InterfaceATM
{
    partial class smallStatement
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
            this.transactionsGridView = new System.Windows.Forms.DataGridView();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceTextbox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsGridView
            // 
            this.transactionsGridView.AllowUserToAddRows = false;
            this.transactionsGridView.AllowUserToDeleteRows = false;
            this.transactionsGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.transactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGridView.Location = new System.Drawing.Point(8, 34);
            this.transactionsGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transactionsGridView.Name = "transactionsGridView";
            this.transactionsGridView.ReadOnly = true;
            this.transactionsGridView.RowHeadersWidth = 51;
            this.transactionsGridView.Size = new System.Drawing.Size(725, 409);
            this.transactionsGridView.TabIndex = 0;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(8, 11);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(111, 16);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "Account Balance:";
            // 
            // balanceTextbox
            // 
            this.balanceTextbox.AutoSize = true;
            this.balanceTextbox.Location = new System.Drawing.Point(140, 11);
            this.balanceTextbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceTextbox.Name = "balanceTextbox";
            this.balanceTextbox.Size = new System.Drawing.Size(0, 16);
            this.balanceTextbox.TabIndex = 2;
            // 
            // smallStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.balanceTextbox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.transactionsGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "smallStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Small Statement";
            this.Load += new System.EventHandler(this.smallStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionsGridView;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label balanceTextbox;
    }
}