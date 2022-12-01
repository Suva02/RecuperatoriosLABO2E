using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public static class UsuariosHardcodeados
    {
        public static Dictionary<string, string> datosIngresoAdministrador;
        public static Dictionary<string, string> datosIngresoProfesor;
        public static Dictionary<string, string> datosIngresoAlumno;

        /// <summary>
        /// CONSTRUCTOR ESTATICO
        /// </summary>
        static UsuariosHardcodeados()
        {
            UsuariosHardcodeados.datosIngresoAdministrador = new Dictionary<string, string>();
            UsuariosHardcodeados.datosIngresoProfesor = new Dictionary<string, string>();
            UsuariosHardcodeados.datosIngresoAlumno = new Dictionary<string, string>();
        }
    }
}
