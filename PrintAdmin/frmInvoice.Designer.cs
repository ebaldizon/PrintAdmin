namespace PrintAdmin
{
    partial class FrmInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoice));
            this.btnBack = new System.Windows.Forms.Button();
            this.tabInvoices = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInvCustomerIDDown = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInvNumberDown = new System.Windows.Forms.TextBox();
            this.btnCalculateInv = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInvPrice = new System.Windows.Forms.TextBox();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.colNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOrder2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkType2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInitialNum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndNum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayment2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearInvCustomerID = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvCustomerID = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabInvoices.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::PrintAdmin.Properties.Resources.atras;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(151, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 48);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tabInvoices
            // 
            this.tabInvoices.Controls.Add(this.metroTabPage1);
            this.tabInvoices.Location = new System.Drawing.Point(23, 113);
            this.tabInvoices.Name = "tabInvoices";
            this.tabInvoices.SelectedIndex = 0;
            this.tabInvoices.Size = new System.Drawing.Size(1109, 582);
            this.tabInvoices.TabIndex = 13;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel3);
            this.metroTabPage1.Controls.Add(this.dgvInvoices);
            this.metroTabPage1.Controls.Add(this.btnSearInvCustomerID);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.txtInvCustomerID);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1101, 543);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Gestión de Recibos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtInvCustomerIDDown);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtInvNumberDown);
            this.panel3.Controls.Add(this.btnCalculateInv);
            this.panel3.Controls.Add(this.btnSaveInvoice);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtInvBalance);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtInvPayment);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtInvPrice);
            this.panel3.Location = new System.Drawing.Point(1, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 153);
            this.panel3.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(301, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "Cédula:";
            // 
            // txtInvCustomerIDDown
            // 
            this.txtInvCustomerIDDown.BackColor = System.Drawing.Color.Silver;
            this.txtInvCustomerIDDown.Cursor = System.Windows.Forms.Cursors.No;
            this.txtInvCustomerIDDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvCustomerIDDown.Location = new System.Drawing.Point(379, 28);
            this.txtInvCustomerIDDown.Name = "txtInvCustomerIDDown";
            this.txtInvCustomerIDDown.Size = new System.Drawing.Size(123, 27);
            this.txtInvCustomerIDDown.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Orden #:";
            // 
            // txtInvNumberDown
            // 
            this.txtInvNumberDown.BackColor = System.Drawing.Color.Silver;
            this.txtInvNumberDown.Cursor = System.Windows.Forms.Cursors.No;
            this.txtInvNumberDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvNumberDown.Location = new System.Drawing.Point(123, 28);
            this.txtInvNumberDown.Name = "txtInvNumberDown";
            this.txtInvNumberDown.Size = new System.Drawing.Size(123, 27);
            this.txtInvNumberDown.TabIndex = 29;
            // 
            // btnCalculateInv
            // 
            this.btnCalculateInv.BackColor = System.Drawing.Color.White;
            this.btnCalculateInv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateInv.Location = new System.Drawing.Point(809, 87);
            this.btnCalculateInv.Name = "btnCalculateInv";
            this.btnCalculateInv.Size = new System.Drawing.Size(98, 30);
            this.btnCalculateInv.TabIndex = 3;
            this.btnCalculateInv.Text = "Calcular";
            this.btnCalculateInv.UseVisualStyleBackColor = false;
            this.btnCalculateInv.Click += new System.EventHandler(this.btnCalculateInv_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.BackColor = System.Drawing.Color.White;
            this.btnSaveInvoice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.Location = new System.Drawing.Point(913, 87);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(98, 30);
            this.btnSaveInvoice.TabIndex = 4;
            this.btnSaveInvoice.Text = "Guardar";
            this.btnSaveInvoice.UseVisualStyleBackColor = false;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(551, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Saldo:";
            // 
            // txtInvBalance
            // 
            this.txtInvBalance.BackColor = System.Drawing.Color.Silver;
            this.txtInvBalance.Cursor = System.Windows.Forms.Cursors.No;
            this.txtInvBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvBalance.Location = new System.Drawing.Point(614, 90);
            this.txtInvBalance.Name = "txtInvBalance";
            this.txtInvBalance.Size = new System.Drawing.Size(123, 27);
            this.txtInvBalance.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Adelanto:";
            // 
            // txtInvPayment
            // 
            this.txtInvPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvPayment.Location = new System.Drawing.Point(379, 91);
            this.txtInvPayment.Name = "txtInvPayment";
            this.txtInvPayment.Size = new System.Drawing.Size(123, 27);
            this.txtInvPayment.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Valor:";
            // 
            // txtInvPrice
            // 
            this.txtInvPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvPrice.Location = new System.Drawing.Point(123, 87);
            this.txtInvPrice.Name = "txtInvPrice";
            this.txtInvPrice.Size = new System.Drawing.Size(123, 27);
            this.txtInvPrice.TabIndex = 0;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber2,
            this.colDateOrder2,
            this.colCustomerID2,
            this.colName2,
            this.colWorkType2,
            this.colInitialNum2,
            this.colEndNum2,
            this.colPrice2,
            this.colPayment2,
            this.colBalance2});
            this.dgvInvoices.Location = new System.Drawing.Point(1, 70);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(1042, 306);
            this.dgvInvoices.TabIndex = 18;
            this.dgvInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellClick);
            // 
            // colNumber2
            // 
            this.colNumber2.HeaderText = "Orden #";
            this.colNumber2.Name = "colNumber2";
            // 
            // colDateOrder2
            // 
            this.colDateOrder2.HeaderText = "Fecha";
            this.colDateOrder2.Name = "colDateOrder2";
            // 
            // colCustomerID2
            // 
            this.colCustomerID2.HeaderText = "Cédula";
            this.colCustomerID2.Name = "colCustomerID2";
            // 
            // colName2
            // 
            this.colName2.HeaderText = "Nombre";
            this.colName2.Name = "colName2";
            // 
            // colWorkType2
            // 
            this.colWorkType2.HeaderText = "Clase de Trabajo";
            this.colWorkType2.Name = "colWorkType2";
            // 
            // colInitialNum2
            // 
            this.colInitialNum2.HeaderText = "Del N";
            this.colInitialNum2.Name = "colInitialNum2";
            // 
            // colEndNum2
            // 
            this.colEndNum2.HeaderText = "Al N";
            this.colEndNum2.Name = "colEndNum2";
            // 
            // colPrice2
            // 
            this.colPrice2.HeaderText = "Valor";
            this.colPrice2.Name = "colPrice2";
            // 
            // colPayment2
            // 
            this.colPayment2.HeaderText = "Adelanto";
            this.colPayment2.Name = "colPayment2";
            // 
            // colBalance2
            // 
            this.colBalance2.HeaderText = "Saldo";
            this.colBalance2.Name = "colBalance2";
            // 
            // btnSearInvCustomerID
            // 
            this.btnSearInvCustomerID.BackColor = System.Drawing.Color.LightGray;
            this.btnSearInvCustomerID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearInvCustomerID.Location = new System.Drawing.Point(257, 15);
            this.btnSearInvCustomerID.Name = "btnSearInvCustomerID";
            this.btnSearInvCustomerID.Size = new System.Drawing.Size(91, 27);
            this.btnSearInvCustomerID.TabIndex = 1;
            this.btnSearInvCustomerID.Text = "Buscar";
            this.btnSearInvCustomerID.UseVisualStyleBackColor = false;
            this.btnSearInvCustomerID.Click += new System.EventHandler(this.btnSearInvCustomerID_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cédula:";
            // 
            // txtInvCustomerID
            // 
            this.txtInvCustomerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvCustomerID.Location = new System.Drawing.Point(99, 17);
            this.txtInvCustomerID.Name = "txtInvCustomerID";
            this.txtInvCustomerID.Size = new System.Drawing.Size(123, 27);
            this.txtInvCustomerID.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PrintAdmin.Properties.Resources.logotipo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(870, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 14;
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabInvoices);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInvoice";
            this.Text = "Facturación";
            this.tabInvoices.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private MetroFramework.Controls.MetroTabControl tabInvoices;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInvCustomerIDDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInvNumberDown;
        private System.Windows.Forms.Button btnCalculateInv;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInvBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInvPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInvPrice;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOrder2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkType2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInitialNum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndNum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayment2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance2;
        private System.Windows.Forms.Button btnSearInvCustomerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInvCustomerID;
    }
}