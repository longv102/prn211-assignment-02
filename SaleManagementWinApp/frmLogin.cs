using BusinessObjects;
using Microsoft.Extensions.Configuration;
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
    public partial class frmLogin : Form
    {
        ICustomerRepo _cusRepo = new CustomerRepo();
        private static readonly string ADMIN_ROLE = "Admin";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Email and Password MUST required!");
                }
                IConfiguration config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true).Build();
                var adEmail = config["AdminAccount:Email"];
                var adPassword = config["AdminAccount:Password"];
                var adRole = config["AdminAccount:Role"];
                if (email.Equals(adEmail) && password.Equals(adPassword))
                {
                    if (ADMIN_ROLE.Equals(adRole))
                    {
                        frmMain frmMain = new frmMain();
                        frmMain.Show();
                        this.Hide();
                        frmMain.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Your role is not supported!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    Customer loginCustomer = _cusRepo.CheckLogin(email, password);
                    if (loginCustomer != null)
                    {
                        frmCustomerDetail frmCustomerDetail = new frmCustomerDetail();
                        frmCustomerDetail.Show();
                        this.Hide();
                        frmCustomerDetail.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Email or Password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
