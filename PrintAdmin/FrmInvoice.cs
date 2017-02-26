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
    public partial class FrmInvoice : MetroForm
    {
        public FrmInvoice()
        {
            InitializeComponent();
            listOrdersInvoice();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            this.Hide();
            frmHome.ShowDialog();
            this.Close();
        }

        private void btnSearInvCustomerID_Click(object sender, EventArgs e)
        {
            if(txtInvCustomerID.Text == "")
            {
                MessageBox.Show("Por favor rellene el campo de (Cédula).", "PrintAdmin");
            }
            else
            {
                OrderBus orderBus = new OrderBus();
                Order order = new Order();
                order.CustomerID = orderBus.convertLong(txtInvCustomerID.Text);

                DataTable dt = orderBus.readForCustomerIDInv(order);

                if (dt != null)
                {
                    dt.Columns["number"].ColumnName = "Orden #";
                    dt.Columns["dateOrder"].ColumnName = "Fecha";
                    dt.Columns["customerID"].ColumnName = "Cédula";
                    dt.Columns["name"].ColumnName = "Nombre";
                    dt.Columns["workType"].ColumnName = "Clase de trabajo";
                    dt.Columns["initialNum"].ColumnName = "Del Nº";
                    dt.Columns["endNum"].ColumnName = "Al Nº";
                    dt.Columns["price"].ColumnName = "Valor";
                    dt.Columns["payment"].ColumnName = "Adelanto";
                    dt.Columns["balance"].ColumnName = "Saldo";
                    dgvInvoices.Columns.Clear();
                    dgvInvoices.DataSource = dt.DefaultView;
                }
                else
                {
                    MessageBox.Show("No se pudo encontra una Orden", "PrintAdmin");
                }
            }
            
        }

        private void listOrdersInvoice()
        {
            OrderBus orderBus = new OrderBus();
            DataTable dt = orderBus.ListOrdersInvoice();

            if (dt != null)
            {
                dt.Columns["number"].ColumnName = "Orden #";
                dt.Columns["dateOrder"].ColumnName = "Fecha";
                dt.Columns["customerID"].ColumnName = "Cédula";
                dt.Columns["name"].ColumnName = "Nombre";
                dt.Columns["workType"].ColumnName = "Clase de trabajo";
                dt.Columns["initialNum"].ColumnName = "Del Nº";
                dt.Columns["endNum"].ColumnName = "Al Nº";
                dt.Columns["price"].ColumnName = "Valor";
                dt.Columns["payment"].ColumnName = "Adelanto";
                dt.Columns["balance"].ColumnName = "Saldo";
                dgvInvoices.Columns.Clear();
                dgvInvoices.DataSource = dt.DefaultView;
            }
            else
            {
                MessageBox.Show("No se pudo cargar la lista de Recibos", "PrintAdmin");
            }
        }

        private void btnCalculateInv_Click(object sender, EventArgs e)
        {
            if (txtInvPrice.Text == "")
            {
                MessageBox.Show("Por favor rellene campo (Valor).", "PrintAdmin");
            }
            else if(txtInvPayment.Text == "")
            {
                MessageBox.Show("Por favor rellene campo (Adelanto).", "PrintAdmin");
            }
            else
            {
                OrderBus orderBus = new OrderBus();
                float price = orderBus.convertFloat(txtInvPrice.Text);
                float payment = orderBus.convertFloat(txtInvPayment.Text);
                float balance = orderBus.calculateBalance(price, payment);
                txtInvBalance.Text = balance.ToString();
            }
            
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtInvNumberDown.Text = dgvInvoices.Rows[e.RowIndex].Cells["Orden #"].Value.ToString();
                txtInvCustomerIDDown.Text = dgvInvoices.Rows[e.RowIndex].Cells["Cédula"].Value.ToString();
                txtInvPrice.Text = dgvInvoices.Rows[e.RowIndex].Cells["Valor"].Value.ToString();
                txtInvPayment.Text = dgvInvoices.Rows[e.RowIndex].Cells["Adelanto"].Value.ToString();
                txtInvBalance.Text = dgvInvoices.Rows[e.RowIndex].Cells["Saldo"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un Recibo de la tabla", "PrintAdmin");
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (txtInvPrice.Text == "")
            {
                MessageBox.Show("Por favor rellene campo (Valor).", "PrintAdmin");
            }
            else if (txtInvPayment.Text == "")
            {
                MessageBox.Show("Por favor rellene campo (Adelanto).", "PrintAdmin");
            }
            else
            {
                try
                {
                    Order order = new Order();
                    OrderBus orderBus = new OrderBus();

                    order.Price = orderBus.convertFloat(txtInvPrice.Text);
                    order.Payment = orderBus.convertFloat(txtInvPayment.Text);
                    order.Balance = orderBus.calculateBalance(order.Price, order.Payment);
                    order.Number = orderBus.convertInt(txtInvNumberDown.Text);
                    MessageBox.Show(orderBus.updateInvoice(order), "PrintAdmin");
                    listOrdersInvoice();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo calcular el saldo restante", "PrintAdmin");
                }
            }
        }
    }
}
