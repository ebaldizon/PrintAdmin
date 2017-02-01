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
    public partial class FrmCustomer : MetroForm
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            this.Hide();
            frmHome.ShowDialog();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
