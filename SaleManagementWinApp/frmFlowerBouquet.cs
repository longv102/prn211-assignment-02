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
    public partial class frmFlowerBouquet : Form
    {
        IFlowerBouquetRepo _flowerRepo = new FlowerBouquetRepo();
        public frmFlowerBouquet()
        {
            InitializeComponent();
        }

        private void DisableTextBox()
        {
            txtId.Enabled = false;
            txtCategoryId.Enabled = false;
            txtName.Enabled = false;
            txtDescription.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtUnitInStock.Enabled = false;
            txtStatus.Enabled = false;
            txtSupplierId.Enabled = false;
        }

        private void LoadFlowerBouquets()
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = _flowerRepo.GetFlowers();

                txtId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtUnitInStock.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtSupplierId.DataBindings.Clear();

                txtId.DataBindings.Add("Text", source, "FlowerBouquetId");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtName.DataBindings.Add("Text", source, "FlowerBouquetName");
                txtDescription.DataBindings.Add("Text", source, "Description");
                txtUnitInStock.DataBindings.Add("Text", source, "UnitsInStock");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtStatus.DataBindings.Add("Text", source, "FlowerBouquetStatus");
                txtSupplierId.DataBindings.Add("Text", source, "SupplierId");

                dgvResult.DataSource = source;
                dgvResult.Columns["Category"].Visible = false;
                dgvResult.Columns["Supplier"].Visible = false;
                dgvResult.Columns["OrderDetails"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFlowerBouquets(List<FlowerBouquet> list)
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = list;

                txtId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtUnitInStock.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtSupplierId.DataBindings.Clear();

                txtId.DataBindings.Add("Text", source, "FlowerBouquetId");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtName.DataBindings.Add("Text", source, "FlowerBouquetName");
                txtDescription.DataBindings.Add("Text", source, "Description");
                txtUnitInStock.DataBindings.Add("Text", source, "UnitsInStock");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtStatus.DataBindings.Add("Text", source, "FlowerBouquetStatus");
                txtSupplierId.DataBindings.Add("Text", source, "SupplierId");

                dgvResult.DataSource = source;
                dgvResult.Columns["Category"].Visible = false;
                dgvResult.Columns["Supplier"].Visible = false;
                dgvResult.Columns["OrderDetails"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFlowerBouquet_Load(object sender, EventArgs e)
        {
            DisableTextBox();
            LoadFlowerBouquets();
        }

        private void btSearch1_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtSearch.Text;
                if (!string.IsNullOrEmpty(searchValue.Trim()))
                {
                    if (cbId.Checked)
                    {
                        List<FlowerBouquet> result = new List<FlowerBouquet>();
                        FlowerBouquet flower = _flowerRepo.SearchFlowerById(int.Parse(searchValue));
                        if (flower != null)
                        {
                            result.Add(flower);
                            if (result.Any())
                            {
                                LoadFlowerBouquets(result);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No record is matched!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbName.Checked)
                    {
                        List<FlowerBouquet> result = _flowerRepo.SearchFlowerByName(searchValue);
                        if (result.Any())
                        {
                            LoadFlowerBouquets(result);
                        }
                        else
                        {
                            MessageBox.Show("No record is matched!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    LoadFlowerBouquets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSearch2_Click(object sender, EventArgs e)
        {
            try
            {
                var startValue = numStart.Value;
                var endValue = numEnd.Value;
                if (cbPrice.Checked)
                {
                    List<FlowerBouquet> result = _flowerRepo.SearchFlowerBouquetByPrice(startValue, endValue);
                    if (result.Any())
                    {
                        LoadFlowerBouquets(result);
                    }
                    else
                    {
                        MessageBox.Show("No record is matched!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cbQuantity.Checked)
                {
                    List<FlowerBouquet> result = _flowerRepo.SearchFlowerBouquetByQuantity((int)startValue, (int)endValue);
                    if (result.Any())
                    {
                        LoadFlowerBouquets(result);
                    }
                    else
                    {
                        MessageBox.Show("No record is matched!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int flowerId = int.Parse(txtId.Text);
                if (MessageBox.Show("Delete this flower bouquer?", "Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _flowerRepo.DeleteAFlower(flowerId);
                    MessageBox.Show("Delete successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFlowerBouquets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmFlowerDetail frmFlowerDetail = new frmFlowerDetail()
            {
                IsUpdate = false
            };
            frmFlowerDetail.Show();
        }

        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FlowerBouquet flower = new FlowerBouquet()
            {
                FlowerBouquetId = int.Parse(txtId.Text),
                CategoryId = int.Parse(txtCategoryId.Text),
                FlowerBouquetName = txtName.Text,
                Description = txtDescription.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                UnitsInStock = int.Parse(txtUnitInStock.Text),
                FlowerBouquetStatus = byte.Parse(txtStatus.Text),
                SupplierId = int.Parse(txtSupplierId.Text),
            };
            frmFlowerDetail frmFlowerDetail = new frmFlowerDetail()
            {
                IsUpdate = true
            };
            frmFlowerDetail.Show();
        }
    }
}
