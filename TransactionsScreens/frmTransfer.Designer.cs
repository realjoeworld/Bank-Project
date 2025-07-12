namespace BankInterface1.TransactionsScreens
{
    partial class frmTransfer
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtboxTransferValue = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCurrentBalanceClientFrom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchClientFrom = new System.Windows.Forms.Button();
            this.txtboxAccountIDSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCurrentBalanceClientTo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSearchClientTo = new System.Windows.Forms.Button();
            this.txtboxsearchAccountIDTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Purple;
            this.btnTransfer.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(541, 590);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(190, 54);
            this.btnTransfer.TabIndex = 13;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Visible = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtboxTransferValue);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(386, 466);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(517, 107);
            this.panel4.TabIndex = 16;
            this.panel4.Visible = false;
            // 
            // txtboxTransferValue
            // 
            this.txtboxTransferValue.Location = new System.Drawing.Point(98, 59);
            this.txtboxTransferValue.Mask = "0000";
            this.txtboxTransferValue.Name = "txtboxTransferValue";
            this.txtboxTransferValue.Size = new System.Drawing.Size(283, 27);
            this.txtboxTransferValue.TabIndex = 7;
            this.txtboxTransferValue.ValidatingType = typeof(int);
            this.txtboxTransferValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxWithDrawValue_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(495, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Please Enter The Amount You Want To Transfer:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCurrentBalanceClientFrom);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(177, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 92);
            this.panel3.TabIndex = 15;
            // 
            // lblCurrentBalanceClientFrom
            // 
            this.lblCurrentBalanceClientFrom.AutoSize = true;
            this.lblCurrentBalanceClientFrom.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceClientFrom.Location = new System.Drawing.Point(126, 52);
            this.lblCurrentBalanceClientFrom.Name = "lblCurrentBalanceClientFrom";
            this.lblCurrentBalanceClientFrom.Size = new System.Drawing.Size(62, 24);
            this.lblCurrentBalanceClientFrom.TabIndex = 5;
            this.lblCurrentBalanceClientFrom.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Balance:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchClientFrom);
            this.panel2.Controls.Add(this.txtboxAccountIDSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(40, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 187);
            this.panel2.TabIndex = 14;
            // 
            // btnSearchClientFrom
            // 
            this.btnSearchClientFrom.BackColor = System.Drawing.Color.Purple;
            this.btnSearchClientFrom.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClientFrom.ForeColor = System.Drawing.Color.White;
            this.btnSearchClientFrom.Location = new System.Drawing.Point(201, 118);
            this.btnSearchClientFrom.Name = "btnSearchClientFrom";
            this.btnSearchClientFrom.Size = new System.Drawing.Size(190, 54);
            this.btnSearchClientFrom.TabIndex = 2;
            this.btnSearchClientFrom.Text = "Search";
            this.btnSearchClientFrom.UseVisualStyleBackColor = false;
            this.btnSearchClientFrom.Click += new System.EventHandler(this.btnSearchClientFrom_Click);
            // 
            // txtboxAccountIDSearch
            // 
            this.txtboxAccountIDSearch.Location = new System.Drawing.Point(91, 73);
            this.txtboxAccountIDSearch.Name = "txtboxAccountIDSearch";
            this.txtboxAccountIDSearch.Size = new System.Drawing.Size(401, 27);
            this.txtboxAccountIDSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Enter Account ID You Want To Transfer Money From:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 90);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(504, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer Screen";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblCurrentBalanceClientTo);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(789, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 92);
            this.panel5.TabIndex = 17;
            // 
            // lblCurrentBalanceClientTo
            // 
            this.lblCurrentBalanceClientTo.AutoSize = true;
            this.lblCurrentBalanceClientTo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceClientTo.Location = new System.Drawing.Point(126, 52);
            this.lblCurrentBalanceClientTo.Name = "lblCurrentBalanceClientTo";
            this.lblCurrentBalanceClientTo.Size = new System.Drawing.Size(62, 24);
            this.lblCurrentBalanceClientTo.TabIndex = 5;
            this.lblCurrentBalanceClientTo.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Current Balance:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSearchClientTo);
            this.panel6.Controls.Add(this.txtboxsearchAccountIDTo);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(652, 106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(575, 187);
            this.panel6.TabIndex = 16;
            // 
            // btnSearchClientTo
            // 
            this.btnSearchClientTo.BackColor = System.Drawing.Color.Purple;
            this.btnSearchClientTo.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClientTo.ForeColor = System.Drawing.Color.White;
            this.btnSearchClientTo.Location = new System.Drawing.Point(201, 118);
            this.btnSearchClientTo.Name = "btnSearchClientTo";
            this.btnSearchClientTo.Size = new System.Drawing.Size(190, 54);
            this.btnSearchClientTo.TabIndex = 2;
            this.btnSearchClientTo.Text = "Search";
            this.btnSearchClientTo.UseVisualStyleBackColor = false;
            this.btnSearchClientTo.Click += new System.EventHandler(this.btnSearchClientTo_Click);
            // 
            // txtboxsearchAccountIDTo
            // 
            this.txtboxsearchAccountIDTo.Location = new System.Drawing.Point(91, 73);
            this.txtboxsearchAccountIDTo.Name = "txtboxsearchAccountIDTo";
            this.txtboxsearchAccountIDTo.Size = new System.Drawing.Size(401, 27);
            this.txtboxsearchAccountIDTo.TabIndex = 1;
            this.txtboxsearchAccountIDTo.TextChanged += new System.EventHandler(this.txtboxsearchAccountIDTo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(556, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Please Enter Account ID You Want To Transfer Money From:";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 701);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox txtboxTransferValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCurrentBalanceClientFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchClientFrom;
        private System.Windows.Forms.TextBox txtboxAccountIDSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCurrentBalanceClientTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSearchClientTo;
        private System.Windows.Forms.TextBox txtboxsearchAccountIDTo;
        private System.Windows.Forms.Label label7;
    }
}