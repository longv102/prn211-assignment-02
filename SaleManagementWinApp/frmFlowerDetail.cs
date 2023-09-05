using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmFlowerDetail : Form
    {
        public bool IsUpdate { get; set; }
        public FlowerBouquet GetCurrentFlower { get; set; }
        IFlowerBouquetRepo _flowerRepo = new FlowerBouquetRepo();
        public frmFlowerDetail()
        {
            InitializeComponent();
        }

        private void LoadCategories()
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = _flowerRepo.GetCategories();
                cboCategory.DisplayMember = "CategoryName";
                cboCategory.ValueMember = "CategoryId";
                cboCategory.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load categories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = _flowerRepo.GetSuppliers();
                cboSupplier.DisplayMember = "SupplierName";
                cboSupplier.ValueMember = "SupplierId";
                cboSupplier.DataSource = source;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }

        private void frmFlowerDetail_Load(object sender, EventArgs e)
        {
            btAdd.Visible = false;
            btUpdate.Visible = false;
            LoadCategories();
            LoadSuppliers();
            if (IsUpdate)
            {

            }
            else
            {
                txtId.Enabled = true;
                btAdd.Visible = !IsUpdate;
            }
        }
    }
}
