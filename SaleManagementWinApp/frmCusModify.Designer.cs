namespace SaleManagementWinApp
{
    partial class frmCusModify
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
            txtStatus = new TextBox();
            dtpBirthday = new DateTimePicker();
            txtPassword = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtId = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btAdd = new Button();
            btUpdate = new Button();
            btClose = new Button();
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(509, 159);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 32;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(509, 116);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(240, 27);
            dtpBirthday.TabIndex = 31;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(509, 77);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 30;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(509, 36);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(125, 27);
            txtCountry.TabIndex = 29;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(158, 159);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 28;
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 26;
            // 
            // txtId
            // 
            txtId.Location = new Point(158, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(443, 162);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 24;
            label8.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(433, 121);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 23;
            label7.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 80);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 22;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 39);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 21;
            label5.Text = "Country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 162);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 20;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 121);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 19;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 80);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 18;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 39);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // btAdd
            // 
            btAdd.DialogResult = DialogResult.Yes;
            btAdd.Location = new Point(158, 229);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 33;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btUpdate
            // 
            btUpdate.DialogResult = DialogResult.Yes;
            btUpdate.Location = new Point(158, 229);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 34;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(509, 229);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 35;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // frmCusModify
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 350);
            Controls.Add(btClose);
            Controls.Add(btUpdate);
            Controls.Add(btAdd);
            Controls.Add(txtStatus);
            Controls.Add(dtpBirthday);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCusModify";
            Text = "Update & Add";
            Load += frmCusModify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStatus;
        private DateTimePicker dtpBirthday;
        private TextBox txtPassword;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtId;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btAdd;
        private Button btUpdate;
        private Button btClose;
    }
}