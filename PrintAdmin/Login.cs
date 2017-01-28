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
    public partial class Login : MetroForm
    {
        public Login()
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
            Home home = new PrintAdmin.Home();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}
