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
    public partial class frmCustomer : Form
    {
        ICustomerRepo _cusRepo = new CustomerRepo();
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void LoadCustomers()
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = _cusRepo.GetCustomers();

                txtId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                dtpBirthday.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtId.DataBindings.Add("Text", source, "CustomerId");
                txtName.DataBindings.Add("Text", source, "CustomerName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");
                dtpBirthday.DataBindings.Add("Text", source, "Birthday");
                txtStatus.DataBindings.Add("Text", source, "CustomerStatus");

                dgvResult.DataSource = source;
                dgvResult.Columns["Orders"].Visible = false;
                dgvResult.Columns["Password"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisableTextBox()
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            txtPassword.Enabled = false;
            dtpBirthday.Enabled = false;
            txtStatus.Enabled = false;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            DisableTextBox();
            LoadCustomers();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCusModify frmCusModify = new frmCusModify()
            {
                IsUpdate = false
            };
            frmCusModify.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerId = int.Parse(txtId.Text),
                Email = txtEmail.Text,
                CustomerName = txtName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Text,
                Birthday = (DateTime)dtpBirthday.Value,
                CustomerStatus = byte.Parse(txtStatus.Text)
            };
            frmCusModify frmCusModify = new frmCusModify()
            {
                GetCurrentCustomer = customer,
                IsUpdate = true
            };
            frmCusModify.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(txtId.Text);
                if (MessageBox.Show("Delete this customer?", "Delete", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _cusRepo.DeleteACustomer(customerId);
                    MessageBox.Show("Delete successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
