using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaBasesDatos.Clases;
using TareaBasesDatos.Clases.Conexiones;

namespace TareaBasesDatos
{
    public partial class Form1 : Form
    {
        public string[] ArregloAlumnos;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSQLServer_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ClsConexionSQLServer cn = new ClsConexionSQLServer();
            int contador = 0;

            //Selección de archivo plano de datos.
            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\alumno\Desktop";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                ArregloAlumnos = ar.LeerArchivo(archivo);
            }

            //Limpieza y llenado de la base de datos a través del archivo plano.
            cn.borrarTabla();
            foreach (string linea in ArregloAlumnos)
            {
                if (contador > 0)
                {
                    string[] alumno = linea.Split(';');
                    string sql = $"insert into tb_alumnos(Correlativo,Nombre,Parcial1,Parcial2,Parcial3) values({alumno[0]},'{alumno[1]}',{alumno[2]},{alumno[3]},{alumno[4]})";
                    cn.insertar(sql);
                }
                contador++;
            }
        }

        private void buttonMySQL_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ClsConexionMySQL cn = new ClsConexionMySQL();
            int contador = 0;

            //Selección de archivo plano de datos.
            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\alumno\Desktop";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                ArregloAlumnos = ar.LeerArchivo(archivo);
            }

            //Limpieza y llenado de la base de datos a través del archivo plano.
            cn.borrarTabla();
            foreach (string linea in ArregloAlumnos)
            {
                if (contador > 0)
                {
                    string[] alumno = linea.Split(';');
                    string sql = $"insert into tb_alumnos(Correlativo,Nombre,Parcial1,Parcial2,Parcial3) values({alumno[0]},'{alumno[1]}',{alumno[2]},{alumno[3]},{alumno[4]})";
                    cn.insertar(sql);
                }
                contador++;
            }
        }

        private void buttonOracle_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ClsConexionOracle cn = new ClsConexionOracle();
            int contador = 0;

            //Selección de archivo plano de datos.
            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\alumno\Desktop";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                ArregloAlumnos = ar.LeerArchivo(archivo);
            }

            //Limpieza y llenado de la base de datos a través del archivo plano.
            cn.borrarTabla();
            foreach (string linea in ArregloAlumnos)
            {
                if (contador > 0)
                {
                    string[] alumno = linea.Split(';');
                    string sql = $"INSERT INTO TB_ALUMNOS (CORRELATIVO, NOMBRE, PARCIAL1,PARCIAL2,PARCIAL3) VALUES ({alumno[0]}, '{alumno[1]}', {alumno[2]},{alumno[3]},{alumno[4]})";
                    cn.insertar(sql);
                }
                contador++;
            }
        }
    }
}
