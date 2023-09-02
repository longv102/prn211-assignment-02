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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateMainMenu();
        }

        private void CreateMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            ToolStripMenuItem menuCustomer = new ToolStripMenuItem("&Customer Mgmt");
            ToolStripMenuItem menuFlower = new ToolStripMenuItem("&Flower Mgmt");
            ToolStripMenuItem menuOrder = new ToolStripMenuItem("&Order Mgmt");

            mainMenu.Items.AddRange(new ToolStripMenuItem[] { menuCustomer, menuFlower, menuOrder });

            menuCustomer.Click += new EventHandler(menuCustomer_Click);
            menuFlower.Click += new EventHandler(menuFlower_Click);
            menuOrder.Click += new EventHandler(menuOrder_Click);

        }

        private void menuOrder_Click(object? sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.Show();
        }

        private void menuFlower_Click(object? sender, EventArgs e)
        {
            frmFlowerBouquet frmFlowerBouquet = new frmFlowerBouquet();
            frmFlowerBouquet.Show();
        }

        private void menuCustomer_Click(object? sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.Show();
        }

    }
}
