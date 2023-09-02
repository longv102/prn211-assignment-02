namespace SaleManagementWinApp
{
    partial class frmFlowerDetail
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
            txtUnitInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
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
            btReturn = new Button();
            cboCategory = new ComboBox();
            cboSupplier = new ComboBox();
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(566, 114);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 31;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(566, 69);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(125, 27);
            txtUnitInStock.TabIndex = 30;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(566, 27);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 29;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(165, 163);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 28;
            // 
            // txtName
            // 
            txtName.Location = new Point(165, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 27;
            // 
            // txtId
            // 
            txtId.Location = new Point(165, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(477, 160);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 24;
            label8.Text = "Supplier";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(489, 117);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 23;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 72);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 22;
            label6.Text = "Unit In Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 30);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 21;
            label5.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 166);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 20;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 120);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 19;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 75);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 18;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 33);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(175, 218);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 33;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(175, 218);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 34;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btReturn
            // 
            btReturn.Location = new Point(527, 218);
            btReturn.Name = "btReturn";
            btReturn.Size = new Size(94, 29);
            btReturn.TabIndex = 35;
            btReturn.Text = "Return";
            btReturn.UseVisualStyleBackColor = true;
            btReturn.Click += btReturn_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(165, 72);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(125, 28);
            cboCategory.TabIndex = 36;
            // 
            // cboSupplier
            // 
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(566, 157);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(125, 28);
            cboSupplier.TabIndex = 37;
            // 
            // frmFlowerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 319);
            Controls.Add(cboSupplier);
            Controls.Add(cboCategory);
            Controls.Add(btReturn);
            Controls.Add(btUpdate);
            Controls.Add(btAdd);
            Controls.Add(txtStatus);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmFlowerDetail";
            Text = "frmFlowerDetail";
            Load += frmFlowerDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtStatus;
        private TextBox txtUnitInStock;
        private TextBox txtUnitPrice;
        private TextBox txtDescription;
        private TextBox txtName;
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
        private Button btReturn;
        private ComboBox cboCategory;
        private ComboBox cboSupplier;
    }
}