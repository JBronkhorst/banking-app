namespace InterfaceDesktop
{
    partial class viewClients
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
            this.viewClientsGridView = new System.Windows.Forms.DataGridView();
            this.clientCountLabel = new System.Windows.Forms.Label();
            this.clientAmountTextbox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewClientsGridView
            // 
            this.viewClientsGridView.AllowUserToAddRows = false;
            this.viewClientsGridView.AllowUserToDeleteRows = false;
            this.viewClientsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewClientsGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewClientsGridView.Location = new System.Drawing.Point(8, 43);
            this.viewClientsGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewClientsGridView.Name = "viewClientsGridView";
            this.viewClientsGridView.ReadOnly = true;
            this.viewClientsGridView.RowHeadersWidth = 51;
            this.viewClientsGridView.Size = new System.Drawing.Size(1260, 426);
            this.viewClientsGridView.TabIndex = 0;
            // 
            // clientCountLabel
            // 
            this.clientCountLabel.AutoSize = true;
            this.clientCountLabel.Location = new System.Drawing.Point(16, 15);
            this.clientCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientCountLabel.Name = "clientCountLabel";
            this.clientCountLabel.Size = new System.Drawing.Size(146, 16);
            this.clientCountLabel.TabIndex = 1;
            this.clientCountLabel.Text = "Total Amount of Clients:";
            // 
            // clientAmountTextbox
            // 
            this.clientAmountTextbox.AutoSize = true;
            this.clientAmountTextbox.Location = new System.Drawing.Point(207, 15);
            this.clientAmountTextbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientAmountTextbox.Name = "clientAmountTextbox";
            this.clientAmountTextbox.Size = new System.Drawing.Size(0, 16);
            this.clientAmountTextbox.TabIndex = 2;
            // 
            // viewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 476);
            this.Controls.Add(this.clientAmountTextbox);
            this.Controls.Add(this.clientCountLabel);
            this.Controls.Add(this.viewClientsGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "viewClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View clients";
            this.Load += new System.EventHandler(this.viewClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewClientsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewClientsGridView;
        private System.Windows.Forms.Label clientCountLabel;
        private System.Windows.Forms.Label clientAmountTextbox;
    }
}