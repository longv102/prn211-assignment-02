namespace SaleManagementWinApp
{
    partial class frmCustomer
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
            dgvResult = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtId = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            dtpBirthday = new DateTimePicker();
            txtStatus = new TextBox();
            btAdd = new Button();
            btUpdate = new Button();
            btDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(12, 295);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.RowTemplate.Height = 29;
            dgvResult.Size = new Size(736, 137);
            dgvResult.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 33);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 74);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 115);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 156);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 4;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(439, 33);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 5;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(429, 74);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 6;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 115);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 7;
            label7.Text = "Birthday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(439, 156);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 8;
            label8.Text = "Status";
            // 
            // txtId
            // 
            txtId.Location = new Point(154, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 71);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(154, 153);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 12;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(505, 30);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(125, 27);
            txtCountry.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(505, 71);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 14;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(505, 110);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(240, 27);
            dtpBirthday.TabIndex = 15;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(505, 153);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 16;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(79, 221);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 17;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(331, 221);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 18;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDelete
            // 
            btDelete.DialogResult = DialogResult.Yes;
            btDelete.Location = new Point(580, 221);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 19;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 444);
            Controls.Add(btDelete);
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
            Controls.Add(dgvResult);
            Name = "frmCustomer";
            Text = "Customer Management";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtId;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private DateTimePicker dtpBirthday;
        private TextBox txtStatus;
        private Button btAdd;
        private Button btUpdate;
        private Button btDelete;
    }
}