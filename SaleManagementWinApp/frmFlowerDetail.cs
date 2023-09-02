using BusinessObjects;
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
        public frmFlowerDetail()
        {
            InitializeComponent();
        }

        private void LoadCategories()
        {

        }

        private void LoadSuppliers()
        {

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

        }
    }
}
