using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPrograV.CapaNegocios
{
    class clsTipoID
    {
        public string CodigoId;
        public string DescripcionCodigo;
        private DateTime FechaCreacion;
        private int IdUsuarioCreacion;
        private DateTime UltimaFechaModificacion;
        private int IdUltimoUsuarioModificacio;

        public  bool ValidaDatos()
        {
            return true;
        }


    }
}
