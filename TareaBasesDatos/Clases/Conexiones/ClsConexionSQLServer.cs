using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBasesDatos.Clases
{
    class ClsConexionSQLServer
    {
        public SqlConnection conexion;
        public SqlCommand comm;
        private String _conexion { get; }

        public ClsConexionSQLServer()
        {
            _conexion = "Data Source=UMG-VM\\SQLEXPRESS;Initial Catalog=dbprogra;Integrated Security=True";
        }

        public void abrirConexion()
        {
            conexion = new SqlConnection(_conexion);
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public void insertar(String sqll)
        {
            abrirConexion();
            comm = new SqlCommand(sqll, conexion);
            comm.ExecuteNonQuery();
            cerrarConexion();
        }

        public void borrarTabla()
        {
            abrirConexion();
            string sqll = "delete from tb_alumnos";
            comm = new SqlCommand(sqll, conexion);
            comm.ExecuteNonQuery();
            cerrarConexion();
        }
    }
}
