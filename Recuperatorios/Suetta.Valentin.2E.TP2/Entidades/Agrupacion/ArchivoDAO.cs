using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public class ArchivoDAO
    {
        public delegate void DelegadoAvisoArchivo();
        private string pathEscritorio;

        /// <summary>
        /// CONSTRUCTOR SIN PARAMETROS
        /// </summary>
        public ArchivoDAO()
        {
            this.pathEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }


        /// <summary>
        /// METODO QUE SE ENCARGA DE GUARDAR UN ARCHIVO
        /// </summary>
        /// <param name="path"></param>
        /// <param name="alumnos"></param>
        public void GuardarArchivo(string path, List<Alumno> alumnos)
        {
            string pathNuevo = string.Empty;
            StreamWriter sw = null;
            try
            {
                pathNuevo = $"{this.pathEscritorio}\\{path}";
                sw = new StreamWriter(pathNuevo, false);

                foreach (var alumno in alumnos)
                {
                    sw.WriteLine(alumno.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sw is not null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }
        }
    }
}
