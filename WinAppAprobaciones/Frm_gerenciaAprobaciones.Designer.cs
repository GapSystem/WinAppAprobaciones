namespace WinAppAprobaciones
{
    partial class Frm_gerenciaAprobaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pizq = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_director = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pheader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pfooter = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_ordenes = new System.Windows.Forms.DataGridView();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.pizq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pheader.SuspendLayout();
            this.pfooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // pizq
            // 
            this.pizq.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pizq.Controls.Add(this.label3);
            this.pizq.Controls.Add(this.lbl_director);
            this.pizq.Controls.Add(this.pictureBox1);
            this.pizq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pizq.Location = new System.Drawing.Point(0, 0);
            this.pizq.Name = "pizq";
            this.pizq.Size = new System.Drawing.Size(154, 507);
            this.pizq.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // lbl_director
            // 
            this.lbl_director.AutoSize = true;
            this.lbl_director.Location = new System.Drawing.Point(22, 139);
            this.lbl_director.Name = "lbl_director";
            this.lbl_director.Size = new System.Drawing.Size(0, 13);
            this.lbl_director.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppAprobaciones.Properties.Resources.if_malecostume_403022;
            this.pictureBox1.Location = new System.Drawing.Point(43, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pheader
            // 
            this.pheader.BackColor = System.Drawing.Color.SlateBlue;
            this.pheader.Controls.Add(this.btn_cargar);
            this.pheader.Controls.Add(this.label2);
            this.pheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pheader.Location = new System.Drawing.Point(154, 0);
            this.pheader.Name = "pheader";
            this.pheader.Size = new System.Drawing.Size(658, 88);
            this.pheader.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "LISTADO DE ORDENES DE COMPRA";
            // 
            // pfooter
            // 
            this.pfooter.BackColor = System.Drawing.Color.SlateBlue;
            this.pfooter.Controls.Add(this.btn_cancelar);
            this.pfooter.Controls.Add(this.btn_grabar);
            this.pfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pfooter.Location = new System.Drawing.Point(154, 458);
            this.pfooter.Name = "pfooter";
            this.pfooter.Size = new System.Drawing.Size(658, 49);
            this.pfooter.TabIndex = 2;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(98, 6);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(17, 6);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_grabar.TabIndex = 0;
            this.btn_grabar.Text = "APROBAR";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_ordenes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(154, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 370);
            this.panel1.TabIndex = 3;
            // 
            // dgv_ordenes
            // 
            this.dgv_ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ordenes.Location = new System.Drawing.Point(0, 0);
            this.dgv_ordenes.Name = "dgv_ordenes";
            this.dgv_ordenes.Size = new System.Drawing.Size(658, 370);
            this.dgv_ordenes.TabIndex = 0;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(34, 50);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(128, 32);
            this.btn_cargar.TabIndex = 1;
            this.btn_cargar.Text = "CARGAR ORDENES";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // Frm_gerenciaAprobaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pfooter);
            this.Controls.Add(this.pheader);
            this.Controls.Add(this.pizq);
            this.Name = "Frm_gerenciaAprobaciones";
            this.Text = " APROBACIONES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_gerenciaAprobaciones_Load);
            this.pizq.ResumeLayout(false);
            this.pizq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pheader.ResumeLayout(false);
            this.pheader.PerformLayout();
            this.pfooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pizq;
        private System.Windows.Forms.Panel pheader;
        private System.Windows.Forms.Panel pfooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_ordenes;
        private System.Windows.Forms.Label lbl_director;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cargar;
    }
}

