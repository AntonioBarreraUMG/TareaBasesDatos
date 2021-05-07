using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBasesDatos.Clases
{
    class ClsArchivo
    {
        public string[] LeerArchivo(String archivo)
        {
            String[] lineas = File.ReadAllLines(archivo);
            return lineas;
        }
    }
}
