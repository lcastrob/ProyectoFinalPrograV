using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectoPrograV.CapaNegocios;

namespace ProjectoPrograV.CapaPresentacion
{
    public partial class FrmMantenimientoId : Form
    {
        public FrmMantenimientoId()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           clsTipoID TipoId= new clsTipoID();
           TipoId.CodigoId = TxtCodigoID.Text;
           TipoId.DescripcionCodigo = TxtDescripcionID.Text;
        }
    }
}
