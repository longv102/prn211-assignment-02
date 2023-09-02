namespace SaleManagementWinApp
{
    partial class frmFlowerBouquet
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dgvResult = new DataGridView();
            txtId = new TextBox();
            txtCategoryId = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitInStock = new TextBox();
            txtStatus = new TextBox();
            txtSupplierId = new TextBox();
            groupBox1 = new GroupBox();
            cbId = new CheckBox();
            cbName = new CheckBox();
            btSearch1 = new Button();
            txtSearch = new TextBox();
            groupBox2 = new GroupBox();
            cbPrice = new CheckBox();
            cbQuantity = new CheckBox();
            label10 = new Label();
            label9 = new Label();
            btSearch2 = new Button();
            numStart = new NumericUpDown();
            numEnd = new NumericUpDown();
            btAdd = new Button();
            btDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEnd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 35);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 77);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Category ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 122);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 168);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 35);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Unit Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(545, 77);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 5;
            label6.Text = "Unit In Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(565, 122);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 6;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(553, 165);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 7;
            label8.Text = "Supplier ID";
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(12, 361);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.RowTemplate.Height = 29;
            dgvResult.Size = new Size(860, 147);
            dgvResult.TabIndex = 8;
            dgvResult.CellDoubleClick += dgvResult_CellDoubleClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(178, 32);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 9;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(178, 74);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(125, 27);
            txtCategoryId.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(178, 119);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(178, 165);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 12;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(642, 32);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 13;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(642, 74);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(125, 27);
            txtUnitInStock.TabIndex = 14;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(642, 119);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 15;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(642, 161);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(125, 27);
            txtSupplierId.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbId);
            groupBox1.Controls.Add(cbName);
            groupBox1.Controls.Add(btSearch1);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Location = new Point(21, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 100);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // cbId
            // 
            cbId.AutoSize = true;
            cbId.Location = new Point(245, 14);
            cbId.Name = "cbId";
            cbId.Size = new Size(46, 24);
            cbId.TabIndex = 3;
            cbId.Text = "ID";
            cbId.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            cbName.AutoSize = true;
            cbName.Location = new Point(245, 63);
            cbName.Name = "cbName";
            cbName.Size = new Size(71, 24);
            cbName.TabIndex = 2;
            cbName.Text = "Name";
            cbName.UseVisualStyleBackColor = true;
            // 
            // btSearch1
            // 
            btSearch1.Location = new Point(144, 38);
            btSearch1.Name = "btSearch1";
            btSearch1.Size = new Size(81, 29);
            btSearch1.TabIndex = 1;
            btSearch1.Text = "Search";
            btSearch1.UseVisualStyleBackColor = true;
            btSearch1.Click += btSearch1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(129, 27);
            txtSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbPrice);
            groupBox2.Controls.Add(cbQuantity);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btSearch2);
            groupBox2.Controls.Add(numStart);
            groupBox2.Controls.Add(numEnd);
            groupBox2.Location = new Point(487, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 100);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // cbPrice
            // 
            cbPrice.AutoSize = true;
            cbPrice.Location = new Point(273, 63);
            cbPrice.Name = "cbPrice";
            cbPrice.Size = new Size(63, 24);
            cbPrice.TabIndex = 5;
            cbPrice.Text = "Price";
            cbPrice.UseVisualStyleBackColor = true;
            // 
            // cbQuantity
            // 
            cbQuantity.AutoSize = true;
            cbQuantity.Location = new Point(273, 26);
            cbQuantity.Name = "cbQuantity";
            cbQuantity.Size = new Size(87, 24);
            cbQuantity.TabIndex = 4;
            cbQuantity.Text = "Quantity";
            cbQuantity.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(103, 20);
            label10.Name = "label10";
            label10.Size = new Size(25, 20);
            label10.TabIndex = 3;
            label10.Text = "To";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 20);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 2;
            label9.Text = "From";
            // 
            // btSearch2
            // 
            btSearch2.Location = new Point(181, 44);
            btSearch2.Name = "btSearch2";
            btSearch2.Size = new Size(75, 29);
            btSearch2.TabIndex = 1;
            btSearch2.Text = "Search";
            btSearch2.UseVisualStyleBackColor = true;
            btSearch2.Click += btSearch2_Click;
            // 
            // numStart
            // 
            numStart.Location = new Point(20, 46);
            numStart.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numStart.Name = "numStart";
            numStart.Size = new Size(53, 27);
            numStart.TabIndex = 1;
            // 
            // numEnd
            // 
            numEnd.Location = new Point(103, 46);
            numEnd.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numEnd.Name = "numEnd";
            numEnd.Size = new Size(57, 27);
            numEnd.TabIndex = 0;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(384, 235);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(80, 29);
            btAdd.TabIndex = 19;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btDelete
            // 
            btDelete.DialogResult = DialogResult.Yes;
            btDelete.Location = new Point(384, 287);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(80, 29);
            btDelete.TabIndex = 20;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // frmFlowerBouquet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 520);
            Controls.Add(btDelete);
            Controls.Add(btAdd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtSupplierId);
            Controls.Add(txtStatus);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtCategoryId);
            Controls.Add(txtId);
            Controls.Add(dgvResult);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmFlowerBouquet";
            Text = "frmFlowerBouquet";
            Load += frmFlowerBouquet_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dgvResult;
        private TextBox txtId;
        private TextBox txtCategoryId;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtUnitPrice;
        private TextBox txtUnitInStock;
        private TextBox txtStatus;
        private TextBox txtSupplierId;
        private GroupBox groupBox1;
        private CheckBox cbId;
        private CheckBox cbName;
        private Button btSearch1;
        private TextBox txtSearch;
        private GroupBox groupBox2;
        private Button btAdd;
        private Button btDelete;
        private NumericUpDown numEnd;
        private Button btSearch2;
        private NumericUpDown numStart;
        private Label label10;
        private Label label9;
        private CheckBox cbPrice;
        private CheckBox cbQuantity;
    }
}