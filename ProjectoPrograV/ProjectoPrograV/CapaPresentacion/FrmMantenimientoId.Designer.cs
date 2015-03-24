namespace ProjectoPrograV.CapaPresentacion
{
    partial class FrmMantenimientoId
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
            this.TxtCodigoID = new System.Windows.Forms.TextBox();
            this.dgvListaTiposID = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDescripcionID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTiposID)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCodigoID
            // 
            this.TxtCodigoID.Location = new System.Drawing.Point(226, 61);
            this.TxtCodigoID.Name = "TxtCodigoID";
            this.TxtCodigoID.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoID.TabIndex = 0;
            this.TxtCodigoID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvListaTiposID
            // 
            this.dgvListaTiposID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTiposID.Location = new System.Drawing.Point(563, 44);
            this.dgvListaTiposID.Name = "dgvListaTiposID";
            this.dgvListaTiposID.Size = new System.Drawing.Size(325, 150);
            this.dgvListaTiposID.TabIndex = 16;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(691, 214);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 22;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(414, 111);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 21;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(414, 171);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(414, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 24);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Descripción del ID";
            // 
            // TxtDescripcionID
            // 
            this.TxtDescripcionID.Location = new System.Drawing.Point(177, 96);
            this.TxtDescripcionID.Name = "TxtDescripcionID";
            this.TxtDescripcionID.Size = new System.Drawing.Size(201, 20);
            this.TxtDescripcionID.TabIndex = 28;
            // 
            // FrmMantenimientoId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 442);
            this.Controls.Add(this.TxtDescripcionID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaTiposID);
            this.Controls.Add(this.TxtCodigoID);
            this.Name = "FrmMantenimientoId";
            this.Text = "FrmMantenimientoId";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTiposID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigoID;
        private System.Windows.Forms.DataGridView dgvListaTiposID;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDescripcionID;
    }
}