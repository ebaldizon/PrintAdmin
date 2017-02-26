namespace PrintAdmin
{
    partial class FrmDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDB));
            this.btnDownloadDB = new System.Windows.Forms.Button();
            this.btnUploadDB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDownloadDB
            // 
            this.btnDownloadDB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadDB.Location = new System.Drawing.Point(106, 303);
            this.btnDownloadDB.Name = "btnDownloadDB";
            this.btnDownloadDB.Size = new System.Drawing.Size(192, 28);
            this.btnDownloadDB.TabIndex = 0;
            this.btnDownloadDB.Text = "Descargar Respaldo";
            this.btnDownloadDB.UseVisualStyleBackColor = true;
            this.btnDownloadDB.Click += new System.EventHandler(this.btnDownloadDB_Click);
            // 
            // btnUploadDB
            // 
            this.btnUploadDB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadDB.Location = new System.Drawing.Point(332, 303);
            this.btnUploadDB.Name = "btnUploadDB";
            this.btnUploadDB.Size = new System.Drawing.Size(192, 28);
            this.btnUploadDB.TabIndex = 1;
            this.btnUploadDB.Text = "Cargar Respaldo";
            this.btnUploadDB.UseVisualStyleBackColor = true;
            this.btnUploadDB.Click += new System.EventHandler(this.btnUploadDB_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PrintAdmin.Properties.Resources.guardar_respaldo_db;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(106, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::PrintAdmin.Properties.Resources.atras;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(180, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 48);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PrintAdmin.Properties.Resources.cargar_respaldo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(332, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 100);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PrintAdmin.Properties.Resources.logotipo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(462, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 6;
            // 
            // FrmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 453);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUploadDB);
            this.Controls.Add(this.btnDownloadDB);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDB";
            this.Text = "Base de Datos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDownloadDB;
        private System.Windows.Forms.Button btnUploadDB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}