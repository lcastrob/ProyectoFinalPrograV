using ProjectoPrograV.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectoPrograV
{
    public partial class FrmPantallaPrincipal : Form
    {
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tipoDeIdentificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoId MantenimientoId = new FrmMantenimientoId();
            MantenimientoId.Show();
        }
    }
}
