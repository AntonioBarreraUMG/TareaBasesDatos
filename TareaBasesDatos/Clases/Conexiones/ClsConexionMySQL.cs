using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBasesDatos.Clases.Conexiones
{
    class ClsConexionMySQL
    {
        public MySqlConnection conexion;
        public MySqlCommand comm;
        private String _conexion { get; }

        public ClsConexionMySQL()
        {
            _conexion = "server = localhost; port = 3306; user id = root; password = Umg$2019; database = dbprogra;";
        }

        public void abrirConexion()
        {
            conexion = new MySqlConnection(_conexion);
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public void insertar(String sqll)
        {
            abrirConexion();
            comm = new MySqlCommand(sqll, conexion);
            comm.ExecuteNonQuery();
            cerrarConexion();
        }

        public void borrarTabla()
        {
            abrirConexion();
            string sqll = "delete from tb_alumnos";
            comm = new MySqlCommand(sqll, conexion);
            comm.ExecuteNonQuery();
            cerrarConexion();
        }
    }
}
