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
    public partial class frmCusModify : Form
    {
        public bool IsUpdate { get; set; }
        public Customer GetCurrentCustomer { get; set; }
        ICustomerRepo _cusRepo = new CustomerRepo();
        public frmCusModify()
        {
            InitializeComponent();
        }

        private void frmCusModify_Load(object sender, EventArgs e)
        {
            btAdd.Visible = false;
            btUpdate.Visible = false;
            if (IsUpdate)
            {
                txtId.Enabled = false;
                txtStatus.Enabled = false;
                txtPassword.Enabled = false;
                btUpdate.Visible = IsUpdate;

                txtId.Text = GetCurrentCustomer.CustomerId.ToString();
                txtName.Text = GetCurrentCustomer.CustomerName;
                txtEmail.Text = GetCurrentCustomer.Email;
                txtCity.Text = GetCurrentCustomer.City;
                txtCountry.Text = GetCurrentCustomer.Country;
                txtPassword.Text = GetCurrentCustomer.Password;
                txtStatus.Text = GetCurrentCustomer.CustomerStatus.ToString();
                dtpBirthday.Text = GetCurrentCustomer.Birthday.ToString();
            }
            else
            {
                txtStatus.Enabled = false;
                txtStatus.Text = 1.ToString();
                btAdd.Visible = !IsUpdate;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer()
                {
                    CustomerId = int.Parse(txtId.Text),
                    CustomerName = txtName.Text,
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Birthday = (DateTime)dtpBirthday.Value,
                    Password = txtPassword.Text,
                    CustomerStatus = byte.Parse(txtStatus.Text)

                };
                if (MessageBox.Show("Add this customer?", "Add", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _cusRepo.AddACustomer(customer);
                    MessageBox.Show("Update successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer()
                {
                    CustomerId = GetCurrentCustomer.CustomerId,
                    CustomerName = txtName.Text,
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Birthday = (DateTime)dtpBirthday.Value,
                    Password = GetCurrentCustomer.Password,
                    CustomerStatus = GetCurrentCustomer.CustomerStatus

                };
                if (MessageBox.Show("Update this customer?", "Update", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _cusRepo.UpdateACustomer(customer);
                    MessageBox.Show("Update successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
