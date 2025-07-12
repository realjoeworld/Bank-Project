namespace BankInterface1
{
    partial class frmShowAllClients
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridShowAllClients = new System.Windows.Forms.DataGridView();
            this.pnlShowClientsNumber = new System.Windows.Forms.Panel();
            this.lblClientsTotalNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowAllClients)).BeginInit();
            this.pnlShowClientsNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(549, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show All Clients ";
            // 
            // dataGridShowAllClients
            // 
            this.dataGridShowAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShowAllClients.Location = new System.Drawing.Point(108, 330);
            this.dataGridShowAllClients.Name = "dataGridShowAllClients";
            this.dataGridShowAllClients.RowHeadersWidth = 62;
            this.dataGridShowAllClients.RowTemplate.Height = 29;
            this.dataGridShowAllClients.Size = new System.Drawing.Size(1147, 477);
            this.dataGridShowAllClients.TabIndex = 1;
            // 
            // pnlShowClientsNumber
            // 
            this.pnlShowClientsNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlShowClientsNumber.Controls.Add(this.lblClientsTotalNumber);
            this.pnlShowClientsNumber.Controls.Add(this.label2);
            this.pnlShowClientsNumber.Controls.Add(this.pictureBox1);
            this.pnlShowClientsNumber.Location = new System.Drawing.Point(457, 101);
            this.pnlShowClientsNumber.Name = "pnlShowClientsNumber";
            this.pnlShowClientsNumber.Size = new System.Drawing.Size(438, 214);
            this.pnlShowClientsNumber.TabIndex = 2;
            // 
            // lblClientsTotalNumber
            // 
            this.lblClientsTotalNumber.AutoSize = true;
            this.lblClientsTotalNumber.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblClientsTotalNumber.ForeColor = System.Drawing.Color.White;
            this.lblClientsTotalNumber.Location = new System.Drawing.Point(316, 116);
            this.lblClientsTotalNumber.Name = "lblClientsTotalNumber";
            this.lblClientsTotalNumber.Size = new System.Drawing.Size(39, 43);
            this.lblClientsTotalNumber.TabIndex = 2;
            this.lblClientsTotalNumber.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clients \r\nTotal Number:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankInterface1.Properties.Resources.TotalClientsIcon;
            this.pictureBox1.Location = new System.Drawing.Point(27, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmShowAllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 849);
            this.Controls.Add(this.pnlShowClientsNumber);
            this.Controls.Add(this.dataGridShowAllClients);
            this.Controls.Add(this.panel1);
            this.Name = "frmShowAllClients";
            this.Text = "ShowAllClients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowAllClients_FormClosing);
            this.Load += new System.EventHandler(this.ShowAllClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowAllClients)).EndInit();
            this.pnlShowClientsNumber.ResumeLayout(false);
            this.pnlShowClientsNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridShowAllClients;
        private System.Windows.Forms.Panel pnlShowClientsNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClientsTotalNumber;
        private System.Windows.Forms.Label label2;
    }
}