namespace InterfaceDesktop
{
    partial class transactionHistory
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
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsGridView
            // 
            this.transactionsGridView.AllowUserToAddRows = false;
            this.transactionsGridView.AllowUserToDeleteRows = false;
            this.transactionsGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.transactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGridView.Location = new System.Drawing.Point(8, 6);
            this.transactionsGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transactionsGridView.Name = "transactionsGridView";
            this.transactionsGridView.ReadOnly = true;
            this.transactionsGridView.RowHeadersWidth = 51;
            this.transactionsGridView.Size = new System.Drawing.Size(725, 436);
            this.transactionsGridView.TabIndex = 0;
            // 
            // transactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 446);
            this.Controls.Add(this.transactionsGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "transactionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction History";
            this.Load += new System.EventHandler(this.transactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionsGridView;
    }
}