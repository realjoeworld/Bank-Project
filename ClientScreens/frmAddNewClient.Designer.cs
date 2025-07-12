namespace BankInterface1
{
    partial class frmAddNewClient
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxBalance = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxAccountID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.btnLAddClinet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtboxPassword = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 85);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(426, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Client";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtboxPassword);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtboxBalance);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtboxAccountID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtboxEmail);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtboxPhoneNumber);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtboxLastName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtboxFirstName);
            this.panel2.Location = new System.Drawing.Point(44, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 294);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(688, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Balance:";
            // 
            // txtboxBalance
            // 
            this.txtboxBalance.Location = new System.Drawing.Point(692, 155);
            this.txtboxBalance.Mask = "000000";
            this.txtboxBalance.Name = "txtboxBalance";
            this.txtboxBalance.Size = new System.Drawing.Size(226, 27);
            this.txtboxBalance.TabIndex = 10;
            this.txtboxBalance.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(374, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Account ID:";
            // 
            // txtboxAccountID
            // 
            this.txtboxAccountID.Location = new System.Drawing.Point(378, 155);
            this.txtboxAccountID.Name = "txtboxAccountID";
            this.txtboxAccountID.Size = new System.Drawing.Size(248, 27);
            this.txtboxAccountID.TabIndex = 8;
            this.txtboxAccountID.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtboxAccountID.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(39, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email:";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(43, 155);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(248, 27);
            this.txtboxEmail.TabIndex = 6;
            this.txtboxEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtboxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(688, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number";
            // 
            // txtboxPhoneNumber
            // 
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(692, 58);
            this.txtboxPhoneNumber.Mask = "0000000000";
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(226, 27);
            this.txtboxPhoneNumber.TabIndex = 4;
            this.txtboxPhoneNumber.ValidatingType = typeof(int);
            this.txtboxPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxPhoneNumber_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(374, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(378, 58);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(248, 27);
            this.txtboxLastName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(39, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(43, 58);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(248, 27);
            this.txtboxFirstName.TabIndex = 0;
            // 
            // btnLAddClinet
            // 
            this.btnLAddClinet.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnLAddClinet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLAddClinet.ForeColor = System.Drawing.Color.White;
            this.btnLAddClinet.Location = new System.Drawing.Point(255, 481);
            this.btnLAddClinet.Name = "btnLAddClinet";
            this.btnLAddClinet.Size = new System.Drawing.Size(227, 68);
            this.btnLAddClinet.TabIndex = 2;
            this.btnLAddClinet.Text = "Add New Client";
            this.btnLAddClinet.UseVisualStyleBackColor = false;
            this.btnLAddClinet.Click += new System.EventHandler(this.btnLAddClinet_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(605, 481);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(227, 68);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(381, 243);
            this.txtboxPassword.Mask = "0000";
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(245, 27);
            this.txtboxPassword.TabIndex = 12;
            this.txtboxPassword.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(377, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Passsord";
            // 
            // frmAddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 571);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLAddClinet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddNewClient";
            this.Text = "frmAddNewClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtboxPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxAccountID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtboxBalance;
        private System.Windows.Forms.Button btnLAddClinet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtboxPassword;
    }
}