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
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            InitializeMyControls();
        }

        public void InitializeMyControls()
        {
            txtPassword.PasswordChar = '*';
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            UserBus userBus = new UserBus();
            if(userBus.login(txtUser.Text, txtPassword.Text))
            {
                FrmHome frmHome = new PrintAdmin.FrmHome();
                this.Hide();
                frmHome.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto", "PrintAdmin");
            }

            
        }
    }
}
