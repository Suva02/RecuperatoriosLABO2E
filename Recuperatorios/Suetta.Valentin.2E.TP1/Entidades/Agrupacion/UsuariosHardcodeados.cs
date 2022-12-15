using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Agrupacion
{
    public static class UsuariosHardcodeados
    {
        public static Dictionary<string, string> usuariosHarcodeados;

        /// <summary>
        /// CONSTRUCTOR ESTATICO
        /// </summary>
        static UsuariosHardcodeados()
        {
            usuariosHarcodeados = new Dictionary<string, string>();
        }
    }
}
