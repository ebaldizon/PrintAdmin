﻿namespace PrintAdmin
{
    partial class FrmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ordenes de Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Facturación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuarios del Sistema";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Base de Datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Información";
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.White;
            this.btnInformation.BackgroundImage = global::PrintAdmin.Properties.Resources.ayuda;
            this.btnInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformation.Location = new System.Drawing.Point(367, 317);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(127, 118);
            this.btnInformation.TabIndex = 5;
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnDB
            // 
            this.btnDB.BackColor = System.Drawing.Color.White;
            this.btnDB.BackgroundImage = global::PrintAdmin.Properties.Resources.datos;
            this.btnDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDB.Location = new System.Drawing.Point(217, 317);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(127, 118);
            this.btnDB.TabIndex = 4;
            this.btnDB.UseVisualStyleBackColor = false;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.BackgroundImage = global::PrintAdmin.Properties.Resources.usuarios;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Location = new System.Drawing.Point(65, 317);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(127, 118);
            this.btnUser.TabIndex = 3;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.White;
            this.btnInvoice.BackgroundImage = global::PrintAdmin.Properties.Resources.facturacion;
            this.btnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.Location = new System.Drawing.Point(367, 157);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(127, 118);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.White;
            this.btnCustomers.BackgroundImage = global::PrintAdmin.Properties.Resources.clientes;
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.Location = new System.Drawing.Point(217, 157);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(127, 118);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.White;
            this.btnOrders.BackgroundImage = global::PrintAdmin.Properties.Resources.ordenes;
            this.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.Location = new System.Drawing.Point(67, 157);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(127, 118);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PrintAdmin.Properties.Resources.logotipo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(537, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 100);
            this.panel1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarDeSesiónToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menú";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cambiarDeSesiónToolStripMenuItem
            // 
            this.cambiarDeSesiónToolStripMenuItem.Name = "cambiarDeSesiónToolStripMenuItem";
            this.cambiarDeSesiónToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cambiarDeSesiónToolStripMenuItem.Text = "Cambiar de Sesión";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}