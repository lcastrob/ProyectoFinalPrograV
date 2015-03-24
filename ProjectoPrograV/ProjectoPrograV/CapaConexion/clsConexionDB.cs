using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPrograV.CapaConexion
{
    class clsConexionDB
    {
  String stringConexion;
        String usuario;
        String baseDatos;
        String servidor;
        SqlConnection miConexion = new SqlConnection();
        SqlCommand miSqlCommand = new SqlCommand();

        private void abrirConexion()
        {
            miConexion.ConnectionString = " server= . ; initial catalog = ManejaDocumentos1; integrated security  = true";
            miConexion.Open();
        
        }

        public void ejecutarSentenciaSql(String sqlCommandTex, SqlParameter [] misParametros)
       {
           abrirConexion();
           miSqlCommand.CommandType = System.Data.CommandType.Text;
           miSqlCommand.Connection = this.miConexion;
           miSqlCommand.CommandText = sqlCommandTex;

           miSqlCommand.Parameters.AddRange( misParametros);
           miSqlCommand.ExecuteNonQuery();
           this.miConexion.Close();

        }

        public SqlDataReader consultarInformacion(String sqlCommandTex, SqlParameter[] misParametros)
        {
            miSqlCommand = new SqlCommand();
            abrirConexion();
            miSqlCommand.CommandType = System.Data.CommandType.Text;
            miSqlCommand.Connection = this.miConexion;
            miSqlCommand.CommandText = sqlCommandTex;

            if (misParametros !=  null)
                miSqlCommand.Parameters.AddRange(misParametros);
            SqlDataReader miDr =  miSqlCommand.ExecuteReader();
            return miDr;
            
        }
    }
}