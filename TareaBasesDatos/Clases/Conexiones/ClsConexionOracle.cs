using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBasesDatos.Clases.Conexiones
{
    class ClsConexionOracle
    {
        public OracleConnection conexion;
        public OracleCommand comm;
        private String _conexion { get; }

        public ClsConexionOracle()
        {
            _conexion = "DATA SOURCE = umg ;PASSWORD=Umg$19;USER ID=system;";
        }

        public void abrirConexion()
        {
            conexion = new OracleConnection(_conexion);
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public void insertar(String sqll)
        {
            abrirConexion();
            comm = new OracleCommand(sqll, conexion);
            comm.ExecuteNonQuery();
            cerrarConexion();
        }

        public void borrarTabla()
        {
            abrirConexion();
            string sqll = "DELETE FROM TB_ALUMNOS";
            comm = new OracleCommand(sqll, conexion);
            comm.ExecuteNonQuery();
            cerrarConexion();
        }
    }
}
