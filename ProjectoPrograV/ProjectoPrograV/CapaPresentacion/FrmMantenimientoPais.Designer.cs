namespace ProjectoPrograV.CapaPresentacion
{
    partial class FrmMantenimientoPais
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
            this.TxtDescripcionPais = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaPaises = new System.Windows.Forms.DataGridView();
            this.TxtCodigoPais = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDescripcionPais
            // 
            this.TxtDescripcionPais.Location = new System.Drawing.Point(193, 118);
            this.TxtDescripcionPais.Name = "TxtDescripcionPais";
            this.TxtDescripcionPais.Size = new System.Drawing.Size(201, 20);
            this.TxtDescripcionPais.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Descripción del País";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(707, 236);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 35;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(430, 133);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 34;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(430, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(430, 162);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 24);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Codigo País";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvListaPaises
            // 
            this.dgvListaPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPaises.Location = new System.Drawing.Point(579, 66);
            this.dgvListaPaises.Name = "dgvListaPaises";
            this.dgvListaPaises.Size = new System.Drawing.Size(325, 150);
            this.dgvListaPaises.TabIndex = 30;
            // 
            // TxtCodigoPais
            // 
            this.TxtCodigoPais.Location = new System.Drawing.Point(242, 83);
            this.TxtCodigoPais.Name = "TxtCodigoPais";
            this.TxtCodigoPais.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoPais.TabIndex = 29;
            // 
            // FrmMantenimientoPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 367);
            this.Controls.Add(this.TxtDescripcionPais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaPaises);
            this.Controls.Add(this.TxtCodigoPais);
            this.Name = "FrmMantenimientoPais";
            this.Text = "Mantenimiento Pais";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDescripcionPais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaPaises;
        private System.Windows.Forms.TextBox TxtCodigoPais;
    }
}