using Business;
using Entities;
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
            listCustomers();
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
            CustomerBus customerBus = new CustomerBus();
            MessageBox.Show(customerBus.create(txtId.Text, txtName.Text, txtTelephone1.Text, txtTelephone2.Text, txtEmail.Text), "PrintAdmin");
            listCustomers();
            clearTxts();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            CustomerBus customerBus = new CustomerBus();
            DataTable dt;

            dt = customerBus.read(txtId.Text, txtName.Text, txtTelephone1.Text, txtTelephone2.Text, txtEmail.Text);
            if (dt != null)
            {
                dt.Columns["id"].ColumnName = "Cédula";
                dt.Columns["name"].ColumnName = "Nombre";
                dt.Columns["telephone1"].ColumnName = "Teléfono 1";
                dt.Columns["telephone2"].ColumnName = "Teléfono 2";
                dt.Columns["email"].ColumnName = "Correo";
                dgvCustomers.Columns.Clear();
                dgvCustomers.DataSource = dt.DefaultView;
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el usuario", "PrintAdmin");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CustomerBus customerBus = new CustomerBus();
            MessageBox.Show(customerBus.update(txtId.Text, txtName.Text, txtTelephone1.Text, txtTelephone2.Text, txtEmail.Text), "PrintAdmin");
            listCustomers();
            clearTxts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustomerBus customerBus = new CustomerBus();
            MessageBox.Show(customerBus.delete(txtId.Text, txtName.Text, txtTelephone1.Text, txtTelephone2.Text, txtEmail.Text), "PrintAdmin");
            listCustomers();
            clearTxts();
        }

        private void listCustomers()
        {
            CustomerBus customerBus = new CustomerBus();

            DataTable dt = customerBus.listCustomers();
            if (dt != null)
            {
                dt.Columns["id"].ColumnName = "Cédula";
                dt.Columns["name"].ColumnName = "Nombre";
                dt.Columns["telephone1"].ColumnName = "Teléfono 1";
                dt.Columns["telephone2"].ColumnName = "Teléfono 2";
                dt.Columns["email"].ColumnName = "Correo";
                dgvCustomers.Columns.Clear();
                dgvCustomers.DataSource = dt.DefaultView;
            }
            else
            {
                MessageBox.Show("No se pudo cargar la lista de usuarios", "PrintAdmin");
            }
        }

        private void clearTxts()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtTelephone1.Text = "";
            txtTelephone2.Text = "";
            txtEmail.Text = "";
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dgvCustomers.Rows[e.RowIndex].Cells["Cédula"].Value.ToString();
                txtName.Text = dgvCustomers.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtTelephone1.Text = dgvCustomers.Rows[e.RowIndex].Cells["Teléfono 1"].Value.ToString();
                txtTelephone2.Text = dgvCustomers.Rows[e.RowIndex].Cells["Teléfono 2"].Value.ToString();
                txtEmail.Text = dgvCustomers.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
