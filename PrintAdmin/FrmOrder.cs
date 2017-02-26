using Business;
using Entities;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintAdmin
{
    public partial class FrmOrder : MetroForm
    {
        Byte[] DesignArray;
        DataTable dtOrder;
        
        public FrmOrder()
        {
            InitializeComponent();
            
            ultimateNumber();
            listOrders();
            
            listCustomers();
            listOrdersInvoice();
            modComponents();
        }

        public void modComponents()
        {
            mtcOrders.SelectedIndex = 0;
            pnlOrder.AutoScroll = true;
            txtNameFile.Text = "N/A";
            txtNameFile.Enabled = false;
            txtName.Enabled = false;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            this.Hide();
            frmHome.ShowDialog();
            
            this.Close();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = openFileDialog1.OpenFile();
                //string path = Path.GetExtension("hola.mva");
                this.DesignArray = ReadFully(stream);
                txtNameFile.Text = openFileDialog1.SafeFileName;
                //txtNameFile.Text = path;
            }
        }

        public static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }

        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            OrderBus orderBus = new OrderBus();

            order.Number = orderBus.convertInt(txtNumberOrder.Text);
            order.DateOrder = dtmpOrder.Value;
            order.CustomerID = orderBus.convertLong(txtCustomerID.Text);
            order.DateDelivery = dtmpDelivery.Value;
            order.DeliveredBy = txtDeliveredBy.Text;
            order.WorkType = txtWork.Text;
            order.Computer = txtComputer.Text;
            order.Iron = rbtnIron.Checked;
            order.Paper = rbtnPaper.Checked;
            order.Quantity = txtQuantity.Text;
            order.Ink = txtInk.Text;
            order.Sheets = txtSheets.Text;
            order.Trait1 = txtTrait1.Text;
            order.Trait2 = txtTrait2.Text;
            order.Trait3 = txtTrait3.Text;
            order.Trait4 = txtTrait4.Text;
            order.Trait5 = txtTrait5.Text;
            order.Trait6 = txtTrait6.Text;
            order.Size = txtSize.Text;
            order.Glued = txtGlued.Text;
            order.Perforated = txtPerforated.Text;
            order.Changes = txtChanges.Text;
            order.Holes = txtHoles.Text;
            order.InitialNum = orderBus.convertInt(txtInitialNum.Text);
            order.EndNum = orderBus.convertInt(txtEndNum.Text);
            order.Observations = txtObservations.Text;
            order.Design = orderBus.validateDesign(this.DesignArray);
            order.NameDesign = txtNameFile.Text;
            order.Price = orderBus.convertFloat(txtPrice.Text);
            order.Payment = orderBus.convertFloat(txtPayment.Text);
            order.Balance = orderBus.convertFloat(txtBalance.Text);

            MessageBox.Show(orderBus.create(order), "PrintAdmin");

            //string testRBTN = rbtnIron.Checked.ToString();
        }

        private void btnReadOrder_Click(object sender, EventArgs e)
        {
            OrderBus orderBus = new OrderBus();

            DataTable dt = orderBus.readForNumber(txtNumberOrder.Text);

            if (dt != null)
            {
                try
                {
                    cleanTextBoxs();
                    txtNumberOrder.Text = dt.Rows[0]["number"].ToString();
                    dtmpOrder.Text = dt.Rows[0]["dateOrder"].ToString();
                    txtCustomerID.Text = dt.Rows[0]["customerID"].ToString();
                    dtmpDelivery.Text = dt.Rows[0]["dateDelivery"].ToString();
                    txtDeliveredBy.Text = dt.Rows[0]["deliveredBy"].ToString();
                    txtWork.Text = dt.Rows[0]["workType"].ToString();
                    txtComputer.Text = dt.Rows[0]["computer"].ToString();
                    rbtnIron.Checked = Convert.ToBoolean(dt.Rows[0]["iron"].ToString());
                    rbtnPaper.Checked = Convert.ToBoolean(dt.Rows[0]["paper"].ToString());
                    txtQuantity.Text = dt.Rows[0]["quantity"].ToString();
                    txtInk.Text = dt.Rows[0]["ink"].ToString();
                    txtSheets.Text = dt.Rows[0]["sheets"].ToString();
                    txtTrait1.Text = dt.Rows[0]["trait1"].ToString();
                    txtTrait2.Text = dt.Rows[0]["trait2"].ToString();
                    txtTrait3.Text = dt.Rows[0]["trait3"].ToString();
                    txtTrait4.Text = dt.Rows[0]["trait4"].ToString();
                    txtTrait5.Text = dt.Rows[0]["trait5"].ToString();
                    txtTrait6.Text = dt.Rows[0]["trait6"].ToString();
                    txtSize.Text = dt.Rows[0]["size"].ToString();
                    txtGlued.Text = dt.Rows[0]["glued"].ToString();
                    txtPerforated.Text = dt.Rows[0]["perforated"].ToString();
                    txtChanges.Text = dt.Rows[0]["changes"].ToString();
                    txtHoles.Text = dt.Rows[0]["holes"].ToString();
                    txtInitialNum.Text = dt.Rows[0]["initialNum"].ToString();
                    txtEndNum.Text = dt.Rows[0]["endNum"].ToString();
                    txtObservations.Text = dt.Rows[0]["observations"].ToString();
                    txtNameFile.Text = dt.Rows[0]["nameDesign"].ToString();
                    this.DesignArray = (byte[])dt.Rows[0]["design"];
                    txtPrice.Text = dt.Rows[0]["price"].ToString();
                    txtPayment.Text = dt.Rows[0]["payment"].ToString();
                    txtBalance.Text = dt.Rows[0]["balance"].ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cliente no encontrado, pruebe buscar en el Listado de Clientes", "PrintAdmin");
                }
            }
        }

        private void btnReadList_Click(object sender, EventArgs e)
        {

            if(txtCustomerID2.Text != "")
            {
                OrderBus orderBus = new OrderBus();
                Order order = new Order();
                order.CustomerID = orderBus.convertLong(txtCustomerID2.Text);

                DataTable dt = orderBus.readForCustomerID(order);

                if (dt != null)
                {
                    /*
                    string a = dt.Rows[0][1].ToString();
                    MessageBox.Show(a);*/

                    dt.Columns["number"].ColumnName = "Número";
                    dt.Columns["dateOrder"].ColumnName = "Fecha";
                    dt.Columns["customerID"].ColumnName = "Cédula";
                    dt.Columns["customerName"].ColumnName = "Cliente";
                    dt.Columns["dateDelivery"].ColumnName = "Fecha de Entrega";
                    dt.Columns["deliveredBy"].ColumnName = "Entregado por";
                    dt.Columns["workType"].ColumnName = "Clase de trabajo";
                    dt.Columns["initialNum"].ColumnName = "Del Nº";
                    dt.Columns["endNum"].ColumnName = "Al Nº";
                    dt.Columns["nameDesign"].ColumnName = "Nombre del Diseño";

                    //select number, dateOrder, dateDelivery, deliveredBy,workType, initialNum, endNum, nameDesign from Orders where number = 1
                    //byte[] buffer = (byte[])dt.Rows[0][2];

                    //System.IO.File.WriteAllBytes(@"C:\Users\Emanuel\Documents\MYSQLTEST.mwb", buffer);

                    // int myNum = int.Parse(dt.Rows[0][0].ToString());

                    dgvOrders.Columns.Clear();
                    dgvOrders.DataSource = dt.DefaultView;
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar la Orden", "PrintAdmin");
                }

            }
            else
            {
                MessageBox.Show("Por favor rellene el campo (Cédula)", "PrintAdmin");
            }
           
        }

        private void btnCustomerID_Click(object sender, EventArgs e)
        {
            if(txtCustomerID.Text != "")
            {
                CustomerBus customerBus = new CustomerBus();
                DataTable dt = customerBus.readForId(txtCustomerID.Text);
                try
                {
                    txtName.Text = dt.Rows[0][1].ToString();
                }
                catch (Exception)
                {
                    txtName.Text = "Cliente no encontrado";
                }
            }
            else
            {
                MessageBox.Show("Por favor rellene el campo de (Cédula)", "PrintAdmin");
            }

            
        }

        private void ultimateNumber()
        {
            OrderBus orderBus = new OrderBus();
            txtNumberOrder.Text = orderBus.ultimateOrder().ToString();
        }

        private void listOrders()
        {
            OrderBus orderBus = new OrderBus();
            DataTable dt = orderBus.ListOrders();

            if (dt != null)
            {
                dt.Columns["number"].ColumnName = "Número";
                dt.Columns["dateOrder"].ColumnName = "Fecha";
                dt.Columns["customerID"].ColumnName = "Cédula";
                dt.Columns["customerName"].ColumnName = "Cliente";
                dt.Columns["dateDelivery"].ColumnName = "Fecha de Entrega";
                dt.Columns["deliveredBy"].ColumnName = "Entregado por";
                dt.Columns["workType"].ColumnName = "Clase de trabajo";
                dt.Columns["initialNum"].ColumnName = "Del Nº";
                dt.Columns["endNum"].ColumnName = "Al Nº";
                dt.Columns["nameDesign"].ColumnName = "Nombre del Diseño";
                dgvOrders.Columns.Clear();
                dgvOrders.DataSource = dt.DefaultView;
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la Orden");
            }

        }

        public void calculateBalance()
        {
            try
            {
                float price = float.Parse(txtPrice.Text);
                float payment = float.Parse(txtPayment.Text);
                txtBalance.Text = (price - payment).ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Solamente números en los campos de recibo");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float price = float.Parse(txtPrice.Text);
                float payment = float.Parse(txtPayment.Text);
                txtBalance.Text = (price - payment).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Rellene los campos de (Valor) y (Adelanto)");
            }
        }

        private void btnGetDetail_Click(object sender, EventArgs e)
        {
            
            try
            {
                cleanTextBoxs();
                txtNumberOrder.Text = this.dtOrder.Rows[0]["number"].ToString();
                dtmpOrder.Text = this.dtOrder.Rows[0]["dateOrder"].ToString();
                txtCustomerID.Text = this.dtOrder.Rows[0]["customerID"].ToString();
                dtmpDelivery.Text = this.dtOrder.Rows[0]["dateDelivery"].ToString();
                txtDeliveredBy.Text = this.dtOrder.Rows[0]["deliveredBy"].ToString();
                txtWork.Text = this.dtOrder.Rows[0]["workType"].ToString();
                txtComputer.Text = this.dtOrder.Rows[0]["computer"].ToString();
                rbtnIron.Checked = Convert.ToBoolean(this.dtOrder.Rows[0]["iron"].ToString());
                rbtnPaper.Checked = Convert.ToBoolean(this.dtOrder.Rows[0]["paper"].ToString());
                txtQuantity.Text = this.dtOrder.Rows[0]["quantity"].ToString();
                txtInk.Text = this.dtOrder.Rows[0]["ink"].ToString();
                txtSheets.Text = this.dtOrder.Rows[0]["sheets"].ToString();
                txtTrait1.Text = this.dtOrder.Rows[0]["trait1"].ToString();
                txtTrait2.Text = this.dtOrder.Rows[0]["trait2"].ToString();
                txtTrait3.Text = this.dtOrder.Rows[0]["trait3"].ToString();
                txtTrait4.Text = this.dtOrder.Rows[0]["trait4"].ToString();
                txtTrait5.Text = this.dtOrder.Rows[0]["trait5"].ToString();
                txtTrait6.Text = this.dtOrder.Rows[0]["trait6"].ToString();
                txtSize.Text = this.dtOrder.Rows[0]["size"].ToString();
                txtGlued.Text = this.dtOrder.Rows[0]["glued"].ToString();
                txtPerforated.Text = this.dtOrder.Rows[0]["perforated"].ToString();
                txtChanges.Text = this.dtOrder.Rows[0]["changes"].ToString();
                txtHoles.Text = this.dtOrder.Rows[0]["holes"].ToString();
                txtInitialNum.Text = this.dtOrder.Rows[0]["initialNum"].ToString();
                txtEndNum.Text = this.dtOrder.Rows[0]["endNum"].ToString();
                txtObservations.Text = this.dtOrder.Rows[0]["observations"].ToString();
                txtNameFile.Text = this.dtOrder.Rows[0]["nameDesign"].ToString();
                this.DesignArray = (byte[])this.dtOrder.Rows[0]["design"];
                txtPrice.Text = this.dtOrder.Rows[0]["price"].ToString();
                txtPayment.Text = this.dtOrder.Rows[0]["payment"].ToString();
                txtBalance.Text = this.dtOrder.Rows[0]["balance"].ToString();

                CustomerBus customerBus = new CustomerBus();
                DataTable dtc = customerBus.readForId(txtCustomerID.Text);
                try
                {
                    txtName.Text = dtc.Rows[0][1].ToString();
                }
                catch (Exception)
                {
                    txtName.Text = "Cliente no encontrado";
                }

                mtcOrders.SelectedIndex = 0;
            }
            catch(Exception)
            {
                MessageBox.Show("Para cargar el detalle de la Orden por favor seleccione un cliente de la lista", "PrintAdmin");
            }
          
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //cleanTextBoxs();
                string number = dgvOrders.Rows[e.RowIndex].Cells["Número"].Value.ToString();

                OrderBus orderBus = new OrderBus();

                DataTable dt = orderBus.readForNumber(number);

                this.dtOrder = dt;
            }
            catch (Exception ex)
            {
               
            }

        }

        private void cleanTextBoxs()
        {
            txtNumberOrder.Text = "";
            dtmpOrder.Text = ""; ;
            txtCustomerID.Text = "";
            dtmpDelivery.Text = "";
            txtDeliveredBy.Text = "";
            txtWork.Text = "";
            txtComputer.Text = ""; ;
            rbtnIron.Checked = false;
            rbtnPaper.Checked = false;
            txtQuantity.Text = "";
            txtInk.Text = "";
            txtSheets.Text = "";
            txtTrait1.Text = "";
            txtTrait2.Text = "";
            txtTrait3.Text = "";
            txtTrait4.Text = "";
            txtTrait5.Text = "";
            txtTrait6.Text = "";
            txtSize.Text = "";
            txtGlued.Text = "";
            txtPerforated.Text = "";
            txtChanges.Text = "";
            txtHoles.Text = "";
            txtInitialNum.Text = "";
            txtEndNum.Text = "";
            txtObservations.Text = "";
            txtNameFile.Text = "";
            txtPrice.Text = "";
            txtPayment.Text = "";
            txtBalance.Text = "";
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            OrderBus orderBus = new OrderBus();

            order.Number = orderBus.convertInt(txtNumberOrder.Text);// INT
            order.DateOrder = dtmpOrder.Value;
            order.CustomerID = orderBus.convertLong(txtCustomerID.Text);
            order.DateDelivery = dtmpDelivery.Value;
            order.DeliveredBy = txtDeliveredBy.Text;
            order.WorkType = txtWork.Text;
            order.Computer = txtComputer.Text;
            order.Iron = rbtnIron.Checked;
            order.Paper = rbtnPaper.Checked;
            order.Quantity = txtQuantity.Text;
            order.Ink = txtInk.Text;
            order.Sheets = txtSheets.Text;
            order.Trait1 = txtTrait1.Text;
            order.Trait2 = txtTrait2.Text;
            order.Trait3 = txtTrait3.Text;
            order.Trait4 = txtTrait4.Text;
            order.Trait5 = txtTrait5.Text;
            order.Trait6 = txtTrait6.Text;
            order.Size = txtSize.Text;
            order.Glued = txtGlued.Text;
            order.Perforated = txtPerforated.Text;
            order.Changes = txtChanges.Text;
            order.Holes = txtHoles.Text;
            order.InitialNum = orderBus.convertInt(txtInitialNum.Text);
            order.EndNum = orderBus.convertInt(txtEndNum.Text);
            order.Observations = txtObservations.Text;
            order.Design = orderBus.validateDesign(this.DesignArray);
            order.NameDesign = txtNameFile.Text;
            order.Price = orderBus.convertFloat(txtPrice.Text);
            order.Payment = orderBus.convertFloat(txtPayment.Text);
            order.Balance = orderBus.convertFloat(txtBalance.Text);

            MessageBox.Show(orderBus.update(order));
            listOrders();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            OrderBus orderBus = new OrderBus();
            MessageBox.Show(orderBus.delete(txtNumberOrder.Text), "PrintAdmin");
            listOrders();
        }

        private void btnDDesign_Click(object sender, EventArgs e)
        {
            if(this.DesignArray != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    byte[] buffer = (byte[])this.dtOrder.Rows[0][27];
                    string ext = Path.GetExtension(this.dtOrder.Rows[0][26].ToString());
                    System.IO.File.WriteAllBytes(saveFileDialog1.FileName + ext, buffer);
                    //System.Diagnostics.Process.Start(saveFileDialog1.FileName + ext);
                }
                else
                {
                    MessageBox.Show("No se guardo el archivo", "PrintAdmin");
                }
            }
            else
            {
                MessageBox.Show("Para descargar el diseño por favor seleccione un cliente de la lista", "PrintAdmin");
            }

            
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            CustomerBus customerBus = new CustomerBus();
            MessageBox.Show(customerBus.create(txtListCustomerID.Text, txtListCustomerName.Text, txtListCustomerTel1.Text, txtListCustomerTel2.Text, txtListCustomerEmail.Text), "PrintAdmin");
            listCustomers();
            clearTxtsListCustomers();
        }

        private void btnReadCustomer_Click(object sender, EventArgs e)
        {
            CustomerBus customerBus = new CustomerBus();
            DataTable dt;

            dt = customerBus.read(txtListCustomerID.Text, txtListCustomerName.Text, txtListCustomerTel1.Text, txtListCustomerTel2.Text, txtListCustomerEmail.Text);
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

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            CustomerBus customerBus = new CustomerBus();
            MessageBox.Show(customerBus.update(txtListCustomerID.Text, txtListCustomerName.Text, txtListCustomerTel1.Text, txtListCustomerTel2.Text, txtListCustomerEmail.Text), "PrintAdmin");
            listCustomers();
            clearTxtsListCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            CustomerBus customerBus = new CustomerBus();
            MessageBox.Show(customerBus.delete(txtListCustomerID.Text, txtListCustomerName.Text, txtListCustomerTel1.Text, txtListCustomerTel2.Text, txtListCustomerEmail.Text), "PrintAdmin");
            listCustomers();
            clearTxtsListCustomers();
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
                MessageBox.Show("No se pudo cargar la lista de Clientes", "PrintAdmin");
            }
        }

        private void clearTxtsListCustomers()
        {
            txtListCustomerID.Text = "";
            txtListCustomerName.Text = "";
            txtListCustomerTel1.Text = "";
            txtListCustomerTel2.Text = "";
            txtListCustomerEmail.Text = "";
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtListCustomerID.Text = dgvCustomers.Rows[e.RowIndex].Cells["Cédula"].Value.ToString();
                txtListCustomerName.Text = dgvCustomers.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtListCustomerTel1.Text = dgvCustomers.Rows[e.RowIndex].Cells["Teléfono 1"].Value.ToString();
                txtListCustomerTel2.Text = dgvCustomers.Rows[e.RowIndex].Cells["Teléfono 2"].Value.ToString();
                txtListCustomerEmail.Text = dgvCustomers.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (txtInvPrice.Text == "")
            {
                MessageBox.Show("Por favor rellene el campo (Valor)", "PrintAdmin");
            }
            else if (txtInvPayment.Text == "")
            {
                MessageBox.Show("Por favor rellene el campo (Adelanto)", "PrintAdmin");
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

        private void btnSearInvCustomerID_Click(object sender, EventArgs e)
        {
            if(txtInvCustomerID.Text != "")
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
                    MessageBox.Show("No se encontro Ordenes registradas para este Cliente", "PrintAdmin");
                }
            }
            else
            {
                MessageBox.Show("Por favor rellene el campo de (Cédula)", "PrintAdmin");
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
        private void btnCalculateInv_Click(object sender, EventArgs e)
        {
            if(txtInvPrice.Text == "")
            {
                MessageBox.Show("Por favor rellene el campo (Valor)", "PrintAdmin");
            }
            else if(txtInvPayment.Text == "")
            {
                MessageBox.Show("Por favor rellene el campo (Adelanto)", "PrintAdmin");
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

        private void btnCustomerToOrder_Click(object sender, EventArgs e)
        {
            if (txtListCustomerID.Text != "" || txtListCustomerName.Text != "")
            {
                txtCustomerID.Text = txtListCustomerID.Text;
                txtName.Text = txtListCustomerName.Text;
                mtcOrders.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cliente de la lista para ser cargado en la Orden", "PrintAdmin");
            }
        }

        private void btnCustomerToInvoice_Click(object sender, EventArgs e)
        {
            if (txtListCustomerID.Text != "")
            {
                txtInvCustomerID.Text = txtListCustomerID.Text;
                mtcOrders.SelectedIndex = 3;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cliente de la lista para ser cargado en el Recibo", "PrintAdmin");
            }
        }
    }
}
