using Entities;
using Business;
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
    public partial class FrmUser : MetroForm
    {
        public FrmUser()
        {
            InitializeComponent();
            listUsers();
        }

        public void InitializeTextBoxs()
        {
            txtPassword.PasswordChar = '*';
            txtRepeatPassword.PasswordChar = '*';
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
            UserBus userBus = new UserBus();
            MessageBox.Show(userBus.create(txtId.Text, txtName.Text, txtLastname.Text, txtMail.Text, txtPassword.Text, txtRepeatPassword.Text), "PrintAdmin");
            cleanTxts();
            listUsers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UserBus userBus = new UserBus();
            DataTable dt = userBus.read(txtId.Text, txtName.Text, txtLastname.Text, txtMail.Text, txtPassword.Text, txtRepeatPassword.Text);

            if(dt != null)
            {
                dt.Columns["id"].ColumnName = "Cédula";
                dt.Columns["name"].ColumnName = "Nombre";
                dt.Columns["lastname"].ColumnName = "Apellido";
                dt.Columns["email"].ColumnName = "Correo";
                dt.Columns["password"].ColumnName = "Contraseña";
                tableUsers.Columns.Clear();
                tableUsers.DataSource = dt.DefaultView; 
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el usuario", "PrintAdmin");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserBus userBus = new UserBus();
            MessageBox.Show(userBus.update(txtId.Text, txtName.Text, txtLastname.Text, txtMail.Text, txtPassword.Text, txtRepeatPassword.Text), "PrintAdmin");
            cleanTxts();
            listUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserBus userBus = new UserBus();
            MessageBox.Show(userBus.delete(txtId.Text, txtName.Text, txtLastname.Text, txtMail.Text, txtPassword.Text, txtRepeatPassword.Text), "PrintAdmin");
            cleanTxts();
            listUsers();
        }

        private void listUsers()
        {
            UserBus userBus = new UserBus();
            DataTable dt = userBus.listUsers();
            if (dt != null)
            {
                dt.Columns["id"].ColumnName = "Cédula";
                dt.Columns["name"].ColumnName = "Nombre";
                dt.Columns["lastname"].ColumnName = "Apellido";
                dt.Columns["email"].ColumnName = "Correo";
                dt.Columns["password"].ColumnName = "Contraseña";
                tableUsers.Columns.Clear();
                tableUsers.DataSource = dt.DefaultView;
            }
            else
            {
                MessageBox.Show("No se pudo cargar la lista de usuarios", "PrintAdmin");
            }
        }

        private void tableUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                txtId.Text = tableUsers.Rows[e.RowIndex].Cells["Cédula"].Value.ToString();
                txtName.Text = tableUsers.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtLastname.Text = tableUsers.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                txtMail.Text = tableUsers.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                txtPassword.Text = tableUsers.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
                txtRepeatPassword.Text = tableUsers.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
            }
            catch(Exception ex)
            {
                
            }

        }

        private void cleanTxts()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtLastname.Text = "";
            txtMail.Text = "";
            txtPassword.Text = "";
            txtRepeatPassword.Text = "";
        }
    }
}
