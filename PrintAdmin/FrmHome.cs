using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintAdmin
{
    public partial class FrmHome : MetroForm
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            FrmOrder frmOrder = new FrmOrder();
            this.Hide();
            frmOrder.ShowDialog();
            this.Close();    
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            this.Hide();
            frmCustomer.ShowDialog();
            this.Close();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FrmInvoice frmInvoce = new FrmInvoice();
            this.Hide();
            frmInvoce.ShowDialog();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            this.Hide();
            frmUser.ShowDialog();
            this.Close();
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            FrmDB frmDB = new FrmDB();
            this.Hide();
            frmDB.ShowDialog();
            this.Close();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            FrmInformation frmInformation = new FrmInformation();
            this.Hide();
            frmInformation.ShowDialog();
            this.Close();
        }
    }
}
